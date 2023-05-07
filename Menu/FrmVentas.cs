using Entidades;

namespace FrmVentas
{
    public partial class frmVentas : Form
    {
        List<Cliente> listaClientes;
        List<Producto> listaProductos;

        public frmVentas(List<Cliente> clientes, List<Producto> productos)
        {
            InitializeComponent();
            listaClientes = clientes;
            listaProductos = productos;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvClientes.DataSource = listaClientes;
            dgvClientes.Update();
            dgvClientes.Refresh();

            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Descripcion", "Descripcion");
            //dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Producto item in listaProductos)
            {
                if (this.txtCodigo.Text == item.Codigo.ToString())
                {
                    this.txtDescripcion.Text = item.Descripcion.ToString();
                    this.txtStock.Text = item.Cantidad.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Producto item in listaProductos)
            {
                //agregar una excepcion es caso que no encuentre el codigo de barras
                if (this.txtCodigo.Text == item.Codigo.ToString())
                {
                    dgvProductos.Rows.Add(item.Codigo, item.Descripcion, numUdCantidad.Value);

                    this.txtCodigo.Text = string.Empty;
                    this.txtDescripcion.Text = string.Empty;
                    this.txtStock.Text = string.Empty;
                    this.numUdCantidad.Value = 0;
                }
            }
        }



    }
}