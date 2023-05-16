namespace FrmLogin
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            rdbVendedor = new RadioButton();
            rdbSupervisor = new RadioButton();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(255, 519);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(362, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Ingresar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 328);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 390);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(255, 356);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(362, 31);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(255, 418);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(362, 31);
            txtContraseña.TabIndex = 4;
            // 
            // rdbVendedor
            // 
            rdbVendedor.AutoSize = true;
            rdbVendedor.Location = new Point(257, 261);
            rdbVendedor.Name = "rdbVendedor";
            rdbVendedor.Size = new Size(114, 29);
            rdbVendedor.TabIndex = 5;
            rdbVendedor.TabStop = true;
            rdbVendedor.Text = "Vendedor";
            rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbSupervisor
            // 
            rdbSupervisor.AutoSize = true;
            rdbSupervisor.Location = new Point(476, 261);
            rdbSupervisor.Name = "rdbSupervisor";
            rdbSupervisor.Size = new Size(121, 29);
            rdbSupervisor.TabIndex = 6;
            rdbSupervisor.TabStop = true;
            rdbSupervisor.Text = "Supervisor";
            rdbSupervisor.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 606);
            Controls.Add(rdbSupervisor);
            Controls.Add(rdbVendedor);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private RadioButton rdbVendedor;
        private RadioButton rdbSupervisor;
    }
}