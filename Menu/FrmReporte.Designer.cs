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
            dateTimePicker1 = new DateTimePicker();
            dgvVentas = new DataGridView();
            Acciones = new DataGridViewButtonColumn();
            Ver = new DataGridViewButtonColumn();
            rtbMostrarDatos = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
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
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Acciones, Ver });
            dgvVentas.Location = new Point(11, 77);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.RowTemplate.Height = 33;
            dgvVentas.Size = new Size(785, 258);
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
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.MinimumWidth = 8;
            Ver.Name = "Ver";
            Ver.Width = 150;
            // 
            // rtbMostrarDatos
            // 
            rtbMostrarDatos.Location = new Point(15, 365);
            rtbMostrarDatos.Name = "rtbMostrarDatos";
            rtbMostrarDatos.Size = new Size(781, 420);
            rtbMostrarDatos.TabIndex = 6;
            rtbMostrarDatos.Text = "";
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 804);
            Controls.Add(rtbMostrarDatos);
            Controls.Add(dgvVentas);
            Controls.Add(dateTimePicker1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Load += FrmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvVentas;
        private DataGridViewButtonColumn Acciones;
        private DataGridViewButtonColumn Ver;
        private RichTextBox rtbMostrarDatos;
    }
}