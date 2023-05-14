namespace Menu
{
    partial class FrmReporte
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
            dtpFecha = new DateTimePicker();
            dgvVentas = new DataGridView();
            rtbMostrarDatos = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(13, 45);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(270, 29);
            dtpFecha.TabIndex = 3;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(12, 105);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.RowTemplate.Height = 33;
            dgvVentas.Size = new Size(785, 258);
            dgvVentas.TabIndex = 4;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // rtbMostrarDatos
            // 
            rtbMostrarDatos.Location = new Point(13, 418);
            rtbMostrarDatos.Name = "rtbMostrarDatos";
            rtbMostrarDatos.Size = new Size(781, 420);
            rtbMostrarDatos.TabIndex = 6;
            rtbMostrarDatos.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 385);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 7;
            label1.Text = "Detalle Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 8;
            label2.Text = "Filtrar Reportes";
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 857);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbMostrarDatos);
            Controls.Add(dgvVentas);
            Controls.Add(dtpFecha);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Load += FrmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFecha;
        private DataGridView dgvVentas;
        private RichTextBox rtbMostrarDatos;
        private Label label1;
        private Label label2;
    }
}