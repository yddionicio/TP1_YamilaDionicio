namespace Menu
{
    partial class FrmUsuario
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
            groupBox2 = new GroupBox();
            cmbTipo = new ComboBox();
            txtMail = new TextBox();
            Mail = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtDni = new TextBox();
            Tipo = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            dgvUsuarios = new DataGridView();
            Acciones = new DataGridViewButtonColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbTipo);
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(Mail);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(Tipo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(34, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 533);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Usuario";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(24, 267);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(258, 33);
            cmbTipo.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(24, 329);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(258, 31);
            txtMail.TabIndex = 9;
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.Location = new Point(22, 301);
            Mail.Name = "Mail";
            Mail.Size = new Size(45, 25);
            Mail.TabIndex = 8;
            Mail.Text = "Mail";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(22, 450);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(260, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(260, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(22, 207);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(260, 31);
            txtDni.TabIndex = 1;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Location = new Point(22, 239);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(47, 25);
            Tipo.TabIndex = 2;
            Tipo.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 179);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 2;
            label5.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(22, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(260, 31);
            txtApellido.TabIndex = 1;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 116);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 2;
            label6.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 31);
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
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Acciones });
            dgvUsuarios.Location = new Point(369, 46);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.Size = new Size(730, 533);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 8;
            Acciones.Name = "Acciones";
            Acciones.Width = 150;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 606);
            Controls.Add(groupBox2);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "Usuarios";
            Load += FrmUsuario_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnEditar;
        private Button btnAgregar;
        private NumericUpDown nupCantidad;
        private TextBox txtDni;
        private Label Tipo;
        private Label label5;
        private TextBox txtApellido;
        private Label label6;
        private TextBox txtNombre;
        private Label label7;
        private DataGridView dgvUsuarios;
        private DataGridViewButtonColumn Acciones;
        private TextBox txtMail;
        private Label Mail;
        private ComboBox cmbTipo;
    }
}