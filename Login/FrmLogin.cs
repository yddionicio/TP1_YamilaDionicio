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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            frmMenu menu = new frmMenu();

            if (this.rdbVendedor.Checked && TipoRol.Vendedor.ToString() == this.rdbVendedor.Text)
            {
                if (ValidarUsuario(usuario, contrasena))
                {
                    menu.OcultarMenuItem();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.rdbSupervisor.Checked && TipoRol.Supervisor.ToString() == this.rdbSupervisor.Text)
            {
                if (ValidarUsuario(usuario, contrasena))
                {
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de rol válido", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarUsuario(string usuario, string contraseña)
        {
            foreach (Usuario item in PlataformaVentas.Usuarios)
            {
                if (item.Apellido == usuario && item.Dni == int.Parse(contraseña))
                {
                    return true;
                }
            }
            return false;
        }




    }
}