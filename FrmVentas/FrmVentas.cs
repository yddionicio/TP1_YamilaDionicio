using Entidades;

namespace FrmVentas
{
    public partial class frmVentas : Form
    {
        PlataformaVentas<Cliente> listaClientes;
        List<Producto> listaProductos;

        public frmVentas(List<Producto> productos)
        {
            InitializeComponent();
            listaClientes = new PlataformaVentas<Cliente>();
            listaProductos = productos;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.DataSource = listaClientes.CargarClientes();
            dgvClientes.Update();
            dgvClientes.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Producto item in listaProductos)
            {
                if (this.txtCodigo.Text == item.Codigo.ToString())
                {
                    dgvProductos.Rows.Add(item);
                }
            }
            dgvClientes.Update();
            dgvClientes.Refresh();

        }
    }
}