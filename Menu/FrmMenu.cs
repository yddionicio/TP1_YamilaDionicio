using Entidades;
using FrmProducto;
using FrmVentas;

namespace Menu
{
    public partial class frmMenu : Form
    {
        frmProducto productos;
        frmVentas ventas;
        PlataformaVentas plataformaVentas;
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
            ventas = new frmVentas(plataformaVentas.Clientes, plataformaVentas.Productos);
            ventas.ShowDialog();
        }


    }
}