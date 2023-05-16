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

            bindingSource.DataSource = PlataformaVentas.Usuarios;
            dgvUsuarios.DataSource = bindingSource;

            dgvUsuarios.Update();
            dgvUsuarios.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty && this.txtDni.Text != string.Empty && this.txtMail.Text != string.Empty && this.cmbTipo.Text != string.Empty)
            {
                Usuario u = new Usuario(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), (TipoRol)(this.cmbTipo.SelectedItem), this.txtMail.Text);
                PlataformaVentas.Usuarios.Add(u);

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

                    c.Nombre = this.txtNombre.Text;
                    c.Apellido = this.txtApellido.Text;
                    c.Dni = int.Parse(this.txtDni.Text);
                    c.Rol = (TipoRol)this.cmbTipo.SelectedItem;
                    c.Mail = this.txtMail.Text;

                    row.Cells["Nombre"].Value = c.Nombre;
                    row.Cells["Apellido"].Value = c.Apellido;
                    row.Cells["Dni"].Value = c.Dni;
                    row.Cells["Rol"].Value = c.Rol;
                    row.Cells["Mail"].Value = c.Mail;

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
            if (e.ColumnIndex == dgvUsuarios.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                Usuario p = (Usuario)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;

                PlataformaVentas.Usuarios.Remove(p);

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
