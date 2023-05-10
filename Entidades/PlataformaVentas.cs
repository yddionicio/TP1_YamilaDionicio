using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlataformaVentas
    {
        public static List<Producto> productos;
        public static List<Cliente> clientes;
        private static List<Venta> ventas;

        static PlataformaVentas()
        {
            productos = new List<Producto>();
            clientes = new List<Cliente>();
            ventas = new List<Venta>();
            PlataformaVentas.CargarProductos();
            PlataformaVentas.CargarClientes();
        }

        public List<Producto> Productos
        {
            get { return PlataformaVentas.productos; }
            set { PlataformaVentas.productos = value; }
        }

        public List<Cliente> Clientes
        {
            get { return PlataformaVentas.clientes; }
            set { PlataformaVentas.clientes = value; }
        }

        public List<Venta> Ventas
        {
            get { return PlataformaVentas.ventas; }
            set { PlataformaVentas.ventas = value; }
        }
        public static void CargarProductos()
        {
            Random rdm = new Random();

            productos.Add(new Hardware(rdm.Next(200000, 600000), "Monitor", 2000, TipoConexion.HDMI, 789000, 45));
            productos.Add(new Hardware(rdm.Next(200000, 600000), "Teclado", 2000, TipoConexion.USB, 1000, 5));
            productos.Add(new Software(rdm.Next(200000, 600000), "Visual", "7.0", TipoSistemaOperativo.MacOs, 1000, 5));
            productos.Add(new Software(rdm.Next(200000, 600000), "Photoshop", "9.0", TipoSistemaOperativo.Windows, 2500, 90));
            productos.Add(new Software(123456, "Photoshop", "9.0", TipoSistemaOperativo.Windows, 1200, 90));
            productos.Add(new Software(2222, "aaaaa", "7.0", TipoSistemaOperativo.Linux, 2500, 5));
        }

        public static void CargarClientes()
        {
            clientes.Add(new Cliente("pompo pomposo", 36258147, "pmp@gmail.com", 15926348));
            clientes.Add(new Cliente("aaaa", 36258147, "pmp@gmail.com", 15926348));
            clientes.Add(new Cliente("bbbb", 36258147, "pmp@gmail.com", 15926348));
            clientes.Add(new Cliente("cccc", 36258147, "pmp@gmail.com", 15926348));
        }


    }
}
