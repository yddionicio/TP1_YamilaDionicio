using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu
{
    public partial class Barra : Form
    {
        public Barra()
        {
            InitializeComponent();
        }

        private void Pruebita_Load(object sender, EventArgs e)
        {
        }

        public void UpdateProgressBar(int value)
        {
            this.progressBar1.Value = value;
        }
    }
}
