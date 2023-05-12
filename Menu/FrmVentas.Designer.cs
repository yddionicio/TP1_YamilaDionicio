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
            label6 = new Label();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnBuscar = new Button();
            numUdCantidad = new NumericUpDown();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            btnCrearVenta = new Button();
            groupBox2 = new GroupBox();
            lblRecDes = new Label();
            lblCadena = new Label();
            lblSubtotal = new Label();
            label11 = new Label();
            label10 = new Label();
            lblTotal = new Label();
            btnSimulador = new Button();
            cmbMedioPago = new ComboBox();
            label8 = new Label();
            txtDinero = new TextBox();
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
            dgvClientes.CellClick += dgvClientes_CellClick;
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(numUdCantidad);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Location = new Point(23, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 37);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 8;
            label6.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(322, 65);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(79, 31);
            txtPrecio.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(707, 30);
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
            label4.Location = new Point(407, 37);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 37);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 37);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Menu.Properties.Resources.search;
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Image = Menu.Properties.Resources.search;
            btnBuscar.Location = new Point(597, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 31);
            btnBuscar.TabIndex = 3;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // numUdCantidad
            // 
            numUdCantidad.Location = new Point(510, 64);
            numUdCantidad.Name = "numUdCantidad";
            numUdCantidad.Size = new Size(80, 31);
            numUdCantidad.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(407, 65);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(80, 31);
            txtStock.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(162, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 5;
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
            txtCodigo.Enabled = false;
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
            btnCrearVenta.Location = new Point(588, 865);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(260, 50);
            btnCrearVenta.TabIndex = 4;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblRecDes);
            groupBox2.Controls.Add(lblCadena);
            groupBox2.Controls.Add(lblSubtotal);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnSimulador);
            groupBox2.Controls.Add(cmbMedioPago);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtDinero);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(23, 702);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 157);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Pago";
            // 
            // lblRecDes
            // 
            lblRecDes.AutoSize = true;
            lblRecDes.Location = new Point(707, 74);
            lblRecDes.Name = "lblRecDes";
            lblRecDes.Size = new Size(0, 25);
            lblRecDes.TabIndex = 16;
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Location = new Point(571, 73);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(69, 25);
            lblCadena.TabIndex = 15;
            lblCadena.Text = "label13";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(707, 38);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 25);
            lblSubtotal.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(571, 38);
            label11.Name = "label11";
            label11.Size = new Size(83, 25);
            label11.TabIndex = 13;
            label11.Text = "Subtotal:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 38);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 12;
            label10.Text = "Dinero";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(707, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "label9";
            // 
            // btnSimulador
            // 
            btnSimulador.Location = new Point(344, 64);
            btnSimulador.Name = "btnSimulador";
            btnSimulador.Size = new Size(82, 34);
            btnSimulador.TabIndex = 10;
            btnSimulador.Text = "Simular";
            btnSimulador.UseVisualStyleBackColor = true;
            btnSimulador.Click += btnSimulador_Click;
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(16, 66);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(166, 33);
            cmbMedioPago.TabIndex = 9;
            cmbMedioPago.SelectedIndexChanged += cmbMedioPago_SelectedIndexChanged;
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
            // txtDinero
            // 
            txtDinero.Location = new Point(188, 66);
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new Size(150, 31);
            txtDinero.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(571, 115);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 0;
            label7.Text = "Total a pagar:";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 927);
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
        private ComboBox cmbMedioPago;
        private Label label8;
        private TextBox txtDinero;
        private Label label7;
        private Label label6;
        private TextBox txtPrecio;
        private Label label10;
        private Label lblTotal;
        private Button btnSimulador;
        private Label lblRecDes;
        private Label lblCadena;
        private Label lblSubtotal;
        private Label label11;
    }
}