namespace FrmProducto
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvProducto = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            groupBox2 = new GroupBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            nupCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label6 = new Label();
            txtCodigo = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToOrderColumns = true;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgvProducto.Location = new Point(356, 45);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 62;
            dgvProducto.RowTemplate.Height = 33;
            dgvProducto.Size = new Size(730, 533);
            dgvProducto.TabIndex = 0;
            dgvProducto.CellClick += dgvProducto_CellClick;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.NullValue = "X";
            Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            Eliminar.FlatStyle = FlatStyle.Popup;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "";
            Eliminar.Width = 90;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(21, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 544);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Producto";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(22, 450);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(243, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(22, 490);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(243, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 410);
            button1.Name = "button1";
            button1.Size = new Size(243, 34);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAgregar_Click;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(22, 282);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(243, 31);
            nupCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(22, 207);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(243, 31);
            txtPrecio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 254);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 2;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 179);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 2;
            label5.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(22, 144);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 31);
            txtDescripcion.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 116);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 2;
            label6.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(22, 83);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(243, 31);
            txtCodigo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 55);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 2;
            label7.Text = "Codigo";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 611);
            Controls.Add(groupBox2);
            Controls.Add(dgvProducto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmProducto";
            Text = "Producto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducto;
        private GroupBox groupBox2;
        private NumericUpDown nupCantidad;
        private TextBox txtPrecio;
        private Label label4;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label6;
        private TextBox txtCodigo;
        private Label label7;
        private Button btnEliminar;
        private Button button1;
        private Button btnEditar;
        private DataGridViewButtonColumn Eliminar;
    }
}