using Entidades;
using System.Windows.Forms;
using BindingSource = System.Windows.Forms.BindingSource;
using FrmVentas;

namespace FrmProducto
{
    public partial class frmProducto : Form
    {
        Random rdm;
        List<Producto> listaProductos;
        BindingSource bindingSource;

        public frmProducto(List<Producto> productos)
        {
            InitializeComponent();
            rdm = new Random();
            listaProductos = productos;
            bindingSource = new BindingSource();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = rdm.Next(200000, 600000).ToString();

            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Eliminar.DisplayIndex = dgvProducto.Columns.Count - 1; chequear posicion del boton 

            bindingSource.DataSource = listaProductos;
            dgvProducto.DataSource = bindingSource;

            dgvProducto.Update();
            dgvProducto.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text != string.Empty && this.txtDescripcion.Text != string.Empty && this.nupCantidad.Value != 0)
            {
                Producto p = new Producto(int.Parse(txtCodigo.Text), this.txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(nupCantidad.Value.ToString()));
                listaProductos.Add(p);

                bindingSource.DataSource = listaProductos;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                // Obtén el objeto Producto correspondiente a la fila seleccionada
                Producto producto = (Producto)dgvProducto.SelectedRows[0].DataBoundItem;

                // Elimina el objeto Producto de la lista
                listaProductos.Remove(producto);

                // Actualiza el origen de datos del DataGridView
                bindingSource.ResetBindings(false);
            }
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
                    p.Cantidad = (int)nupCantidad.Value;

                    row.Cells["Descripcion"].Value = p.Descripcion;
                    row.Cells["Precio"].Value = p.Precio;
                    row.Cells["Cantidad"].Value = p.Cantidad;

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
                nupCantidad.Value = producto.Cantidad;
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna del botón
            if (e.ColumnIndex == dgvProducto.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener el objeto Producto correspondiente a la fila seleccionada
                Producto p = (Producto)dgvProducto.Rows[e.RowIndex].DataBoundItem;

                // Eliminar el objeto Producto de la lista
                listaProductos.Remove(p);

                // Actualizar el origen de datos de la DataGridView
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