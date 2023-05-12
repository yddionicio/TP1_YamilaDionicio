using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmCliente : Form
    {
        Random rdm;
        List<Cliente> listaClientes;
        BindingSource bindingSource;
        public FrmCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            rdm = new Random();
            bindingSource = new BindingSource();
            listaClientes = clientes;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSource.DataSource = listaClientes;
            dgvClientes.DataSource = bindingSource;

            dgvClientes.Update();
            dgvClientes.Refresh();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Cliente c = new Cliente(this.txtNombre.Text, int.Parse(this.txtDni.Text), this.txtMail.Text, int.Parse(this.txtTelefono.Text));
            listaClientes.Add(c);

            //bindingSource.DataSource = dgvClientes;
            //dgvClientes.DataSource = bindingSource;

            bindingSource.ResetBindings(false);
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.txtMail.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                Cliente cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                listaClientes.Remove(cliente);
                bindingSource.ResetBindings(false);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvClientes.SelectedRows[0];

                Cliente c = (Cliente)row.DataBoundItem;

                c.Nombre = this.txtNombre.Text;
                c.Dni = int.Parse(this.txtDni.Text);
                c.Email = this.txtMail.Text;
                c.Telefono = int.Parse(this.txtTelefono.Text);

                row.Cells["Nombre"].Value = c.Nombre;
                row.Cells["Dni"].Value = c.Dni;
                row.Cells["Email"].Value = c.Email;
                row.Cells["Telefono"].Value = c.Telefono;

                LimpiarCampos();
            }
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                Cliente cliente = (Cliente)row.DataBoundItem;

                this.txtNombre.Text = cliente.Nombre.ToString();
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

                listaClientes.Remove(c);

                bindingSource.ResetBindings(false);
                LimpiarCampos();
            }
        }


    }
}
