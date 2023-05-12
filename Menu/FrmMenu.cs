using Entidades;
using FrmProducto;
using FrmVentas;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu
{
    public partial class frmMenu : Form
    {
        frmProducto productos;
        frmVentas ventas;
        PlataformaVentas plataformaVentas;
        FrmReporte reportes;
        FrmCliente clientes;
        public frmMenu()
        {
            InitializeComponent();
            plataformaVentas = new PlataformaVentas();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            productos = new frmProducto(plataformaVentas.Productos);
            productos.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventas = new frmVentas(plataformaVentas.Clientes, plataformaVentas.Productos, plataformaVentas.Ventas);
            ventas.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportes = new FrmReporte(plataformaVentas.Ventas);
            reportes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes = new FrmCliente(plataformaVentas.Clientes);
            clientes.ShowDialog();
        }

        public void OcultarMenuItem()
        {
            menuStrip1.Items["reportesToolStripMenuItem"].Visible = false;
        }
    }
}