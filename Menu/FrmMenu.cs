using Entidades;
using FrmProducto;
using FrmVentas;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProducto productos = new frmProducto();
            productos.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte reportes = new FrmReporte();
            reportes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente clientes = new FrmCliente();
            clientes.ShowDialog();
        }

        public void OcultarMenuItem()
        {
            menuStrip1.Items["reportesToolStripMenuItem"].Visible = false;
        }
    }
}