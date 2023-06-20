using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmCliente : Form
    {
        Random rdm;
        BindingSource bindingSource;
        DatosDAO db = new DatosDAO();

        public FrmCliente()
        {
            InitializeComponent();
            rdm = new Random();
            bindingSource = new BindingSource();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSource.DataSource = db.TraerDatosClientes(); //PlataformaVentas.Clientes;
            dgvClientes.DataSource = bindingSource;

            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            verColumn.HeaderText = "Acciones";
            verColumn.Name = "Acciones";
            verColumn.UseColumnTextForButtonValue = true;

            #region chequear si me permite agregar una imagen al boton sino eliminarlo
            // Crea una instancia de DataGridViewImageCell para la imagen del botón
            //DataGridViewImageCell imageCell = new DataGridViewImageCell();
            DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
            buttonCell.Value = Image.FromFile("C:\\Users\\Administrator\\source\\repos\\TP1_YamilaDionicio\\Menu\\Resources\\search.png"); // Ruta de la imagen que deseas mostrar en el botón

            // Asigna la celda de imagen al botón
            //verColumn.CellTemplate = imageCell;
            verColumn.CellTemplate = buttonCell;
            #endregion


            dgvClientes.Columns.Add(verColumn);

            dgvClientes.Update();
            dgvClientes.Refresh();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty && this.txtDni.Text != string.Empty && this.txtMail.Text != string.Empty && this.txtTelefono.Text != string.Empty)
            {
                Cliente c = new Cliente(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), this.txtMail.Text, int.Parse(this.txtTelefono.Text));
                PlataformaVentas.Clientes.Add(c);
                db.InsertarDatosCliente(c);

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
            this.txtMail.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                Cliente cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                PlataformaVentas.Clientes.Remove(cliente);
                bindingSource.ResetBindings(false);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty && this.txtApellido.Text != string.Empty && this.txtDni.Text != string.Empty && this.txtMail.Text != string.Empty && this.txtTelefono.Text != string.Empty)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvClientes.SelectedRows[0];

                    Cliente c = (Cliente)row.DataBoundItem;

                    c.Nombre = this.txtNombre.Text;
                    c.Apellido = this.txtApellido.Text;
                    c.Dni = int.Parse(this.txtDni.Text);
                    c.Email = this.txtMail.Text;
                    c.Telefono = int.Parse(this.txtTelefono.Text);

                    row.Cells["Nombre"].Value = c.Nombre;
                    row.Cells["Apellido"].Value = c.Apellido;
                    row.Cells["Dni"].Value = c.Dni;
                    row.Cells["Email"].Value = c.Email;
                    row.Cells["Telefono"].Value = c.Telefono;

                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                Cliente cliente = (Cliente)row.DataBoundItem;

                this.txtNombre.Text = cliente.Nombre.ToString();
                this.txtApellido.Text = cliente.Apellido.ToString();
                this.txtDni.Text = cliente.Dni.ToString();
                this.txtMail.Text = cliente.Email.ToString();
                this.txtTelefono.Text = cliente.Telefono.ToString();
            }
        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                Cliente c = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                //PlataformaVentas.Clientes.Remove(c);
                db.EliminarDatosCliente(c.Dni);

                //List<Cliente> clientes = db.TraerDatosClientes();

                // Asignar la nueva lista de clientes al DataGridView
                //dgvClientes.DataSource = clientes;
                dgvClientes.DataSource = null;

                dgvClientes.DataSource = db.TraerDatosClientes();

                bindingSource.ResetBindings(false);
                //dgvClientes.Refresh();
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (this.txtTelefono.Text.Length >= 10 && !char.IsControl(e.KeyChar))
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
