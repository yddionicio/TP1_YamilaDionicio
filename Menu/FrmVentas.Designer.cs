namespace FrmVentas
{
    partial class frmVentas
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
            dgvClientes = new DataGridView();
            dgvProductos = new DataGridView();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            numUdCantidad = new NumericUpDown();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            btnCrearVenta = new Button();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUdCantidad).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(23, 47);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 33;
            dgvClientes.Size = new Size(825, 228);
            dgvClientes.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 434);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.RowTemplate.Height = 33;
            dgvProductos.Size = new Size(825, 248);
            dgvProductos.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numUdCantidad);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Location = new Point(23, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(690, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 66);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 38);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 38);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 38);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // numUdCantidad
            // 
            numUdCantidad.Location = new Point(567, 65);
            numUdCantidad.Name = "numUdCantidad";
            numUdCantidad.Size = new Size(80, 31);
            numUdCantidad.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(481, 66);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(80, 31);
            txtStock.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(325, 66);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(162, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(53, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 3;
            label1.Text = "Cod. de Barra";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 65);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "Clientes";
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Location = new Point(588, 834);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(260, 50);
            btnCrearVenta.TabIndex = 4;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(23, 702);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 113);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 33);
            comboBox1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 38);
            label8.Name = "label8";
            label8.Size = new Size(137, 25);
            label8.TabIndex = 8;
            label8.Text = "Medio de Pago:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 38);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 0;
            label7.Text = "Total a pagar:";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 896);
            Controls.Add(groupBox2);
            Controls.Add(btnCrearVenta);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmVentas";
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUdCantidad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridView dgvProductos;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private Button btnCrearVenta;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private NumericUpDown numUdCantidad;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
    }
}