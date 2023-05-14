using Entidades;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
    public partial class FrmReporte : Form
    {
        BindingSource bindingSource;
        public FrmReporte()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVentas.DataSource = PlataformaVentas.Ventas;
            dgvVentas.Columns[1].Visible = false;
            dgvVentas.Columns[2].HeaderText = "Nro Venta";

            DataGridViewButtonColumn descargarColumn = new DataGridViewButtonColumn();
            descargarColumn.HeaderText = "Descargar";
            descargarColumn.Name = "Descargar";
            descargarColumn.UseColumnTextForButtonValue = true;
            dgvVentas.Columns.Add(descargarColumn);

            DataGridViewButtonColumn verColumn = new DataGridViewButtonColumn();
            verColumn.HeaderText = "Ver";
            verColumn.Name = "Ver";
            verColumn.UseColumnTextForButtonValue = true;
            dgvVentas.Columns.Add(verColumn);
        }


        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var test = dgvVentas.Columns;
            if (e.ColumnIndex == dgvVentas.Columns["Descargar"].Index && e.RowIndex >= 0)
            {
                Venta venta = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var excelPackage = new ExcelPackage())
                {
                    excelPackage.Workbook.Properties.Author = "PMP";
                    excelPackage.Workbook.Properties.Title = "Reporte Ventas";
                    var sheet = excelPackage.Workbook.Worksheets.Add("ventas");

                    sheet.Name = "Venta";
                    ExcelRange cell;

                    sheet.Cells[1, 1, 1, 5].Merge = true;
                    cell = sheet.Cells[1, 1];
                    cell.Value = "VENTA";
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 16;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    cell = sheet.Cells[2, 2];
                    cell.Value = "FECHA:";
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                    cell = sheet.Cells[2, 3];
                    cell.Value = venta.Fecha;
                    cell.Style.Font.Bold = false;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                    cell = sheet.Cells[3, 2];
                    cell.Value = "NOMBRE:";
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                    cell = sheet.Cells[3, 3];
                    cell.Value = venta.Cliente.Nombre;
                    cell.Style.Font.Bold = false;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                    cell = sheet.Cells[4, 2];
                    cell.Value = "DNI:";
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                    cell = sheet.Cells[4, 3];
                    cell.Value = venta.Cliente.Dni;
                    cell.Style.Font.Bold = false;
                    cell.Style.Font.Size = 12;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                    sheet.Cells[5, 1, 5, 5].Merge = true;
                    cell = sheet.Cells[5, 1];
                    cell.Value = "DETALLE PRODUCTO";
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.Size = 14;
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    var row = 6;
                    var columna = 1;
                    List<string> lines = new List<string>() { "Codigo", "Descripcion", "Cantidad", "Precio", "Subtotal" };

                    foreach (var item in lines)
                    {
                        cell = sheet.Cells[row, columna];
                        cell.Value = item;
                        cell.Style.Font.Bold = false;
                        cell.Style.Font.Size = 12;
                        cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        columna++;
                    }

                    row++;

                    foreach (Producto item in venta.ListaProdSeleccionados)
                    {
                        columna = 1;
                        lines = new List<string>() { item.Codigo.ToString(), item.Descripcion, item.Cantidad.ToString(), item.Precio.ToString(), (item.Precio * item.Cantidad).ToString() };

                        foreach (var linea in lines)
                        {
                            cell = sheet.Cells[row, columna];
                            cell.Value = linea;
                            cell.Style.Font.Bold = false;
                            cell.Style.Font.Size = 12;
                            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            if (columna > 3)
                            {
                                cell.Style.Numberformat.Format = "#,##0.00";
                            }
                            columna++;
                        }
                        row++;
                    }

                    for (int i = 1; i < sheet.Columns.EndColumn + 1; i++)
                    {
                        sheet.Column(i).AutoFit(30);
                    }

                    sheet.Column(1).AutoFit(15);

                    // Crea un objeto SaveFileDialog
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo Excel|*.xlsx";
                    saveFileDialog.Title = "Guardar Reporte Ventas";

                    // Si el usuario selecciona una ubicación y un nombre de archivo
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guarda el paquete de Excel en la ubicación seleccionada
                        FileInfo file = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(file);

                        MessageBox.Show("El archivo se guardó exitosamente en " + file.FullName, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (e.ColumnIndex == dgvVentas.Columns["Ver"].Index && e.RowIndex >= 0)
            {
                Venta venta = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                string infoVenta = "DETALLE DE VENTA";
                infoVenta += "\n";
                infoVenta += "FECHA: ";
                infoVenta += venta.Fecha.ToString();
                infoVenta += "\n";
                infoVenta += Environment.NewLine;
                infoVenta += venta.Cliente.Mostrar();
                infoVenta += "\n";
                infoVenta += "DETALLE DE PRODUCTO:";

                foreach (Producto p in venta.ListaProdSeleccionados)
                {
                    infoVenta += "\n";
                    infoVenta += p.Mostrar();
                }

                rtbMostrarDatos.Clear();
                rtbMostrarDatos.Text = infoVenta;
            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            List<Venta> ventasFiltradas = new List<Venta>();

            foreach (Venta venta in PlataformaVentas.Ventas)
            {
                if (venta.Fecha.Date == fechaSeleccionada)
                {
                    ventasFiltradas.Add(venta);
                }
            }

            dgvVentas.DataSource = ventasFiltradas;
            dgvVentas.Update();
            dgvVentas.Refresh();
        }
    }
}
