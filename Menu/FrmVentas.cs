using Entidades;
using Menu;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmVentas
{
    public partial class frmVentas : Form
    {
        List<Producto> listaSeleccionado;
        BindingSource bindingSource;

        public Cliente ClienteSeleccionado { get; set; }

        public frmVentas()
        {
            InitializeComponent();
            listaSeleccionado = new List<Producto>();
            bindingSource = new BindingSource();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            this.txtDinero.Enabled = false;
            this.btnSimulador.Enabled = false;

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbMedioPago.Items.Insert(0, "");
            this.cmbMedioPago.DataSource = Enum.GetValues(typeof(TipoPago));
            this.cmbMedioPago.DisplayMember = "Nombre";
            this.cmbMedioPago.SelectedIndex = 0;

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.DataSource = PlataformaVentas.Clientes;

            dgvClientes.Update();
            dgvClientes.Refresh();

            dgvProductos.DataSource = listaSeleccionado;

            #region Agregar columna subtotal
            //DataGridViewColumn columna = new DataGridViewTextBoxColumn();
            //columna.Name = "Subtotal";
            //columna.HeaderText = "Subtotal";
            //dgvProductos.Columns.Insert(4, columna);
            #endregion

            #region chequear que el boton se agregue al final de las columnas
            //DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            //verColumn.HeaderText = "Eliminar";
            //verColumn.Name = "Eliminar";
            //verColumn.UseColumnTextForButtonValue = true;
            //dgvProductos.Columns.Add(verColumn);

            //dgvProductos.Columns.Insert(4, verColumn);
            //int ultimaColumna = dgvProductos.Columns.Count - 1;
            //dgvProductos.Columns.Insert(ultimaColumna + 1, verColumn);
            #endregion

            dgvProductos.Update();
            dgvProductos.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmDatosProductos datosProductos = new FrmDatosProductos(PlataformaVentas.Productos);
            datosProductos.ShowDialog();

            if (datosProductos.ProductoSeleccionado != null)
            {
                Producto productoSeleccionado = datosProductos.ProductoSeleccionado;

                this.txtCodigo.Text = productoSeleccionado.Codigo.ToString();
                this.txtDescripcion.Text = productoSeleccionado.Descripcion.ToString();
                this.txtPrecio.Text = productoSeleccionado.Precio.ToString();
                this.txtStock.Text = productoSeleccionado.Cantidad.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double subtotal = 0;

            if (this.numUdCantidad.Value >= 1)
            {
                if (int.Parse(this.txtStock.Text) >= (int)this.numUdCantidad.Value)
                {
                    foreach (Producto item in PlataformaVentas.Productos)
                    {
                        //agregar una excepcion es caso que no encuentre el codigo de barras
                        if (this.txtCodigo.Text == item.Codigo.ToString())
                        {
                            Producto productoSeleccionado = new Producto(item.Codigo, item.Descripcion, item.Precio, (int)this.numUdCantidad.Value);
                            this.listaSeleccionado.Add(productoSeleccionado);

                            this.txtCodigo.Text = string.Empty;
                            this.txtDescripcion.Text = string.Empty;
                            this.txtPrecio.Text = string.Empty;
                            this.txtStock.Text = string.Empty;
                            this.numUdCantidad.Value = 0;

                            dgvProductos.DataSource = null;
                            dgvProductos.DataSource = listaSeleccionado;
                            dgvProductos.Update();
                            dgvProductos.Refresh();
                        }
                    }

                    this.lblSubtotal.Text = Venta.CalcularSubtotal(listaSeleccionado).ToString();
                }
                else
                {
                    MessageBox.Show("No hay stock suficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                //agregar excepcion 
                MessageBox.Show("Por favor, ingrese la cantidad de productos que desea agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSimulador_Click(object sender, EventArgs e)
        {
            TipoPago tipo = (TipoPago)cmbMedioPago.SelectedItem;
            this.txtDinero.Text = Venta.SimuladorDinero().ToString();

            double subtotal = 0;
            double total = 0;

            if (this.lblSubtotal.Text != "" && double.TryParse(lblSubtotal.Text, out subtotal))
            {
                total = Venta.CalcularPrecioFinal(tipo, out string cadena, subtotal);

                this.lblCadena.Text = cadena;
                this.lblRecDes.Text = total.ToString();
                this.lblTotal.Text = total.ToString();
            }

            if (double.TryParse(this.txtDinero.Text, out double dinero) && double.Parse(this.txtDinero.Text) >= total)
            {
                this.btnCrearVenta.Enabled = true;
            }
            else
            {
                btnCrearVenta.Enabled = false;
                MessageBox.Show("El cliente no contiene el dinero suficiente para realizar esta compra", "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPago tipo = (TipoPago)cmbMedioPago.SelectedItem;

            if (cmbMedioPago.SelectedIndex >= 0)
            {
                if (tipo == TipoPago.Efectivo)
                {
                    this.btnSimulador.Enabled = true;
                    this.btnCrearVenta.Enabled = false;
                }
                else
                {
                    this.btnSimulador.Enabled = false;
                    this.btnCrearVenta.Enabled = true;

                    double subtotal = 0;
                    double total = 0;

                    if (this.lblSubtotal.Text != "" && double.TryParse(lblSubtotal.Text, out subtotal))
                    {
                        total = Venta.CalcularPrecioFinal(tipo, out string cadena, subtotal);

                        this.lblCadena.Text = cadena;
                        this.lblRecDes.Text = total.ToString();
                        this.lblTotal.Text = total.ToString();
                    }
                }
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvClientes.CurrentRow;

                if (this.ClienteSeleccionado != null)
                {
                    Cliente clienteSeleccionado = this.ClienteSeleccionado;
                    Venta venta = new Venta(listaSeleccionado, clienteSeleccionado, DateTime.Now);
                    PlataformaVentas.Ventas.Add(venta);

                    MessageBox.Show("Venta realizada exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult result = MessageBox.Show("¿Desea realizar otra compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.listaSeleccionado.Clear();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Venta rechazada", "Operación invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            this.ClienteSeleccionado = PlataformaVentas.Clientes[rowIndex];
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) // modificar 
        {
            if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                Producto p = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                this.listaSeleccionado.Remove(p);

                bindingSource.ResetBindings(false);
            }
        }




    }
}