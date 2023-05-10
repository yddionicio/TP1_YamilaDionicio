using Entidades;

namespace FrmVentas
{
    public partial class frmVentas : Form
    {
        List<Cliente> listaClientes;
        List<Producto> listaProductos;
        List<Venta> listaVentas;
        List<Producto> listaSeleccionado;
        public frmVentas(List<Cliente> clientes, List<Producto> productos, List<Venta> ventas)
        {
            InitializeComponent();
            listaClientes = clientes;
            listaProductos = productos;
            listaVentas = ventas;
            listaSeleccionado = new List<Producto>();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.cmbMedioPago.DataSource = Enum.GetValues(typeof(Venta.TipoPago));
            this.cmbMedioPago.DisplayMember = "Nombre";

            dgvClientes.DataSource = listaClientes;
            dgvClientes.Update();
            dgvClientes.Refresh();

            dgvProductos.DataSource = listaSeleccionado;
            dgvProductos.Update();
            dgvProductos.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Producto item in listaProductos)
            {
                if (this.txtCodigo.Text == item.Codigo.ToString())
                {
                    this.txtCodigo.Text = item.Codigo.ToString();
                    this.txtDescripcion.Text = item.Descripcion.ToString();
                    this.txtPrecio.Text = item.Precio.ToString();
                    this.txtStock.Text = item.Cantidad.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double subtotal = 0;

            foreach (Producto item in listaProductos)
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

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {

            //foreach (var item in collection)
            //{
            //    Venta.CalcularVenta(numUdCantidad.Value, cmbMedioPago.Text, txtPrecio.Text);
            //}
        }

        private void btnSimulador_Click(object sender, EventArgs e)
        {
            this.txtDinero.Text = Venta.SimuladorDinero().ToString();
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Venta.TipoPago tipo = (Venta.TipoPago)this.cmbMedioPago.SelectedItem;
            //Venta.CalcularPrecioFinal(tipo, lblCadena.Text, Double.Parse(this.lblSubtotal.Text), double.Parse(this.lblRecDes.Text));
        }
    }
}