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
            DatosArchivo datos = new DatosArchivo();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estilos.json");
            Configuracion estilos = datos.LeerJson(path);
            this.btnIngresar.BackColor = Color.FromName(estilos.Color);
            this.picboxImagen.Image = Image.FromFile(estilos.Imagen);
            this.BackColor = Color.FromName(estilos.Fondo);
            //System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(estilos.Sonido);
            //this.btnIngresar.Click += (sender, e) => soundPlayer.Play();
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

        //private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //    if (this.txtUsuario.Text.Length >= 8 && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}