using Entidades;
using Menu;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();

            if (rdbVendedor.Checked && TipoRol.Vendedor.ToString() == rdbVendedor.Text)
            {
                menu.OcultarMenuItem();
            }

            menu.ShowDialog();
        }
    }

}