﻿namespace Menu
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDni = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            dgvClientes = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(7, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 520);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 117);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 9;
            label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(22, 145);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(243, 31);
            txtApellido.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 328);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(243, 31);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(22, 433);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(243, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 393);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(243, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(22, 266);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(243, 31);
            txtMail.TabIndex = 1;
            txtMail.Validating += txtMail_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 300);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 2;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 238);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 2;
            label5.Text = "Mail";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(22, 204);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(243, 31);
            txtDni.TabIndex = 1;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 176);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 2;
            label6.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 31);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 55);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 2;
            label7.Text = "Nombre";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(313, 46);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 33;
            dgvClientes.Size = new Size(755, 520);
            dgvClientes.TabIndex = 4;
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick_1;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 597);
            Controls.Add(groupBox2);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCliente";
            Text = "Clientes";
            Load += FrmCliente_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtMail;
        private Label label4;
        private Label label5;
        private TextBox txtDni;
        private Label label6;
        private TextBox txtNombre;
        private Label label7;
        private DataGridView dgvClientes;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtApellido;
    }
}