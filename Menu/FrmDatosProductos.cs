using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmDatosProductos : Form
    {
        List<Producto> listaProductos;
        public FrmDatosProductos(List<Producto> productos)
        {
            InitializeComponent();
            listaProductos = productos;
        }

        public Producto ProductoSeleccionado { get; set; }
        private void FrmDatosProductos_Load(object sender, EventArgs e)
        {
            this.dgvDatosProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosProductos.DataSource = listaProductos;
            this.dgvDatosProductos.Update();
            this.dgvDatosProductos.Refresh();
        }

        private void dgvDatosProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            this.ProductoSeleccionado = listaProductos[rowIndex];
            this.Close();
        }
    }
}
