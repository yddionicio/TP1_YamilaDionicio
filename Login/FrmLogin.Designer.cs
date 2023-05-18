namespace Login
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
            btnIngresar = new Button();
            rdbVendedor = new RadioButton();
            rdbSupervisor = new RadioButton();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(220, 469);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(368, 47);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // rdbVendedor
            // 
            rdbVendedor.AutoSize = true;
            rdbVendedor.Location = new Point(246, 252);
            rdbVendedor.Name = "rdbVendedor";
            rdbVendedor.Size = new Size(114, 29);
            rdbVendedor.TabIndex = 1;
            rdbVendedor.TabStop = true;
            rdbVendedor.Text = "Vendedor";
            rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbSupervisor
            // 
            rdbSupervisor.AutoSize = true;
            rdbSupervisor.Location = new Point(421, 252);
            rdbSupervisor.Name = "rdbSupervisor";
            rdbSupervisor.Size = new Size(121, 29);
            rdbSupervisor.TabIndex = 2;
            rdbSupervisor.TabStop = true;
            rdbSupervisor.Text = "Supervisor";
            rdbSupervisor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 308);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(246, 336);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(316, 31);
            txtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 370);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(246, 398);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(316, 31);
            txtContraseña.TabIndex = 6;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 543);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(rdbSupervisor);
            Controls.Add(rdbVendedor);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private RadioButton rdbVendedor;
        private RadioButton rdbSupervisor;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContraseña;
    }
}