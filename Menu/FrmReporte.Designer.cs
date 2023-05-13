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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvVentas = new DataGridView();
            Acciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 2;
            label1.Text = "Buscar";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 29);
            dateTimePicker1.TabIndex = 3;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Acciones });
            dgvVentas.Location = new Point(11, 77);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.RowTemplate.Height = 33;
            dgvVentas.Size = new Size(758, 348);
            dgvVentas.TabIndex = 4;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 8;
            Acciones.Name = "Acciones";
            Acciones.Width = 150;
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 437);
            Controls.Add(dgvVentas);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Load += FrmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvVentas;
        private DataGridViewButtonColumn Acciones;
    }
}