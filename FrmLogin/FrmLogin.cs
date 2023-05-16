using Menu;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();

            if (rdbVendedor.Checked && TipoRol.Vendedor.ToString() == rdbVendedor.Text)
            {
                menu.OcultarMenuItem();
            }

            menu.ShowDialog();
            this.Close();
        }
    }
}