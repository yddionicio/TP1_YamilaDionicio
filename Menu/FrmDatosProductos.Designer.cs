namespace Menu
{
    partial class FrmDatosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosProductos));
            dgvDatosProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatosProductos
            // 
            dgvDatosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosProductos.Dock = DockStyle.Fill;
            dgvDatosProductos.Location = new Point(0, 0);
            dgvDatosProductos.Name = "dgvDatosProductos";
            dgvDatosProductos.RowHeadersWidth = 62;
            dgvDatosProductos.RowTemplate.Height = 33;
            dgvDatosProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosProductos.Size = new Size(804, 331);
            dgvDatosProductos.TabIndex = 0;
            dgvDatosProductos.CellClick += dgvDatosProductos_CellClick;
            // 
            // FrmDatosProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 331);
            Controls.Add(dgvDatosProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDatosProductos";
            Text = "Datos";
            Load += FrmDatosProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatosProductos;
    }
}