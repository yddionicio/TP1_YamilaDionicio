using Entidades;
using System.Windows.Forms;
using BindingSource = System.Windows.Forms.BindingSource;
using FrmVentas;

namespace FrmProducto
{
    public partial class frmProducto : Form
    {
        Random rdm;
        BindingSource bindingSource;

        public frmProducto()
        {
            InitializeComponent();
            rdm = new Random();
            bindingSource = new BindingSource();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = rdm.Next(200000, 600000).ToString();

            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Eliminar.DisplayIndex = dgvProducto.Columns.Count - 1; chequear posicion del boton 

            bindingSource.DataSource = PlataformaVentas.Productos;
            dgvProducto.DataSource = bindingSource;

            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            verColumn.HeaderText = "Acciones";
            verColumn.Name = "Acciones";
            verColumn.UseColumnTextForButtonValue = true;
            dgvProducto.Columns.Add(verColumn);
            //dgvProductos.Columns.Insert(4, verColumn);

            dgvProducto.Update();
            dgvProducto.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text != string.Empty && this.txtDescripcion.Text != string.Empty && this.nupCantidad.Value != 0)
            {

                Producto p = new Producto(int.Parse(txtCodigo.Text), this.txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(nupCantidad.Value.ToString()));

                #region
                //Producto p;

                //if (tipoProducto == "Hardware")
                //{
                //    p = new Hardware(int.Parse(txtCodigo.Text), this.txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(nupCantidad.Value.ToString()));
                //}
                //else if (tipoProducto == "Software")
                //{
                //    p = new Software(int.Parse(txtCodigo.Text), this.txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(nupCantidad.Value.ToString()));
                //}
                //else
                //{
                //    MessageBox.Show("Tipo de producto inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                #endregion

                PlataformaVentas.Productos.Add(p);

                bindingSource.DataSource = PlataformaVentas.Productos;
                dgvProducto.DataSource = bindingSource;

                bindingSource.ResetBindings(false);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("¡Por favor complete todos los campos requeridos!", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LimpiarCampos()
        {
            txtCodigo.Text = rdm.Next(200000, 600000).ToString();
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            nupCantidad.Value = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text != string.Empty && this.txtDescripcion.Text != string.Empty && this.nupCantidad.Value != 0)
            {
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = dgvProducto.SelectedRows[0];

                    // Obtener el objeto Producto correspondiente a la fila seleccionada
                    Producto p = (Producto)row.DataBoundItem;

                    // Actualizar los valores del objeto Producto
                    p.Descripcion = txtDescripcion.Text;
                    p.Precio = double.Parse(txtPrecio.Text);
                    p.Stock = (int)nupCantidad.Value;

                    row.Cells["Descripcion"].Value = p.Descripcion;
                    row.Cells["Precio"].Value = p.Precio;
                    row.Cells["Cantidad"].Value = p.Stock;

                    // Limpiar los campos de entrada
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // El usuario hizo clic en una fila
            {
                DataGridViewRow row = dgvProducto.Rows[e.RowIndex];
                Producto producto = (Producto)row.DataBoundItem;

                txtCodigo.Text = producto.Codigo.ToString();
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                nupCantidad.Value = producto.Stock;
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducto.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                Producto p = (Producto)dgvProducto.Rows[e.RowIndex].DataBoundItem;

                PlataformaVentas.Productos.Remove(p);

                bindingSource.ResetBindings(false);
                LimpiarCampos();
            }
        }


        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (this.txtPrecio.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}