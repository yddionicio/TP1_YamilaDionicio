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
            listBox1 = new ListBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(10, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(634, 554);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Buscar reporte";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 677);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FrmReporte";
            Text = "FrmReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}