using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmUsuario : Form
    {
        DatosDAO datos = new DatosDAO();
        UsuariosDAO usuariosDB = new UsuariosDAO();
        BindingSource bindingSource;
        public FrmUsuario()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(TipoRol));
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            verColumn.HeaderText = "Eliminar";
            verColumn.Name = "Eliminar";
            verColumn.UseColumnTextForButtonValue = true;
            dgvUsuarios.Columns.Add(verColumn);

            bindingSource.DataSource = datos.TraerDatosUsuarios();  //PlataformaVentas.Usuarios;
            dgvUsuarios.DataSource = bindingSource;

            dgvUsuarios.Update();
            dgvUsuarios.Refresh();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty && this.txtDni.Text != string.Empty && this.txtMail.Text != string.Empty && this.cmbTipo.Text != string.Empty)
            {
                Usuario u = new Usuario(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), (TipoRol)(this.cmbTipo.SelectedItem), this.txtMail.Text);
                //PlataformaVentas.Usuarios.Add(u);
                datos.InsertarDatosUsuario(u);
                List<Usuario> usu = datos.TraerDatosUsuarios();

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usu;

                bindingSource.ResetBindings(false);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("¡Por favor complete todos los campos requeridos!", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LimpiarCampos()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.cmbTipo.Text = string.Empty;
            this.txtMail.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty && this.txtDni.Text != string.Empty && this.txtMail.Text != string.Empty && this.cmbTipo.Text != string.Empty)
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvUsuarios.SelectedRows[0];

                    Usuario c = (Usuario)row.DataBoundItem;

                    if (this.txtDni.Text != null)
                    {
                        List<Usuario> usu = usuariosDB.GetAll();

                        foreach (var item in usu)
                        {
                            if (item.Dni != Convert.ToInt32(this.txtDni.Text))
                            {
                                MessageBox.Show("Debe ingresar un DNI existente", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    usuariosDB.Update(c);

                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = usuariosDB.GetAll();

                    bindingSource.ResetBindings(false);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                Usuario usuario = (Usuario)row.DataBoundItem;

                this.txtNombre.Text = usuario.Nombre.ToString();
                this.txtApellido.Text = usuario.Apellido.ToString();
                this.txtDni.Text = usuario.Dni.ToString();
                this.cmbTipo.Text = usuario.Rol.ToString();
                this.txtMail.Text = usuario.Mail.ToString();
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                Usuario p = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;

                //PlataformaVentas.Usuarios.Remove(p);
                datos.EliminarDatosUsuario(p.Dni);

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = datos.TraerDatosUsuarios();

                bindingSource.ResetBindings(false);
                LimpiarCampos();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (this.txtDni.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            if (!Regex.IsMatch(this.txtMail.Text, pattern))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

    }
}
