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
            label1 = new Label();
            rdbVendedor = new RadioButton();
            rdbSupervisor = new RadioButton();
            label2 = new Label();
            btnAgregar = new Button();
            label3 = new Label();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // rdbVendedor
            // 
            rdbVendedor.AutoSize = true;
            rdbVendedor.Location = new Point(73, 274);
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
            rdbSupervisor.Location = new Point(238, 274);
            rdbSupervisor.Name = "rdbSupervisor";
            rdbSupervisor.Size = new Size(121, 29);
            rdbSupervisor.TabIndex = 1;
            rdbSupervisor.TabStop = true;
            rdbSupervisor.Text = "Supervisor";
            rdbSupervisor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 359);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(64, 455);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(323, 46);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Ingresar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 370);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(64, 398);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(323, 31);
            txtContraseña.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(127, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 195);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 525);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(rdbSupervisor);
            Controls.Add(rdbVendedor);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdbVendedor;
        private RadioButton rdbSupervisor;
        private Label label2;
        private Button btnAgregar;
        private Label label3;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
    }
}