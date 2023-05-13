using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PlataformaVentas
    {
        private static List<Producto> productos = new List<Producto>();
        private static List<Cliente> clientes = new List<Cliente>();
        private static List<Venta> ventas = new List<Venta>();

        static PlataformaVentas() 
        {
            PlataformaVentas.CargarProductos();
            PlataformaVentas.CargarClientes();
            PlataformaVentas.CargarVentas();
        }

        public static List<Producto> Productos { get => productos; set => productos = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static List<Venta> Ventas { get => ventas; set => ventas = value; }

        public static void CargarProductos()
        {
            Random rdm = new Random();

            Productos.Add(new Hardware(rdm.Next(200000, 600000), "Monitor", 2000, TipoConexion.HDMI, 789000, 45));
            Productos.Add(new Hardware(rdm.Next(200000, 600000), "Teclado", 2000, TipoConexion.USB, 1000, 5));
            Productos.Add(new Software(rdm.Next(200000, 600000), "Visual", "7.0", TipoSistemaOperativo.MacOs, 1000, 5));
            Productos.Add(new Software(rdm.Next(200000, 600000), "Photoshop", "9.0", TipoSistemaOperativo.Windows, 2500, 90));
            Productos.Add(new Software(123456, "Photoshop", "9.0", TipoSistemaOperativo.Windows, 1200, 90));
            Productos.Add(new Software(2222, "aaaaa", "7.0", TipoSistemaOperativo.Linux, 2500, 5));
        }

        public static void CargarClientes()
        {
            Clientes.Add(new Cliente("pompo", "pomposo", 36258147, "pmp@gmail.com", 15926348));
            Clientes.Add(new Cliente("aaaa", "Perez", 36258147, "pmp@gmail.com", 15926348));
            Clientes.Add(new Cliente("bbbb", "garcia", 36258147, "pmp@gmail.com", 15926348));
            Clientes.Add(new Cliente("cccc", "bbb", 36258147, "pmp@gmail.com", 15926348));
        }

        public static void CargarVentas()
        {
            Random rdm = new Random();
            List<Producto> productos = new List<Producto>();
            Cliente c1 = new Cliente("Gustavo", "Bruno", 36258147, "pmp@gmail.com", 15926348);
            Cliente c2 = new Cliente("Ysmila", "Dionicio", 36258147, "pmp@gmail.com", 15926348);
            Cliente c3 = new Cliente("Juan", "Perez", 36258147, "pmp@gmail.com", 15926348);

            productos.Add(new Hardware(rdm.Next(15000, 600000), "Monitor", 2000, TipoConexion.HDMI, 789000, 5));
            productos.Add(new Hardware(rdm.Next(500, 600000), "Teclado", 900, TipoConexion.USB, 200, 9));
            productos.Add(new Hardware(rdm.Next(8692, 600000), "Mouse", 6000, TipoConexion.DVI, 3600, 2));
            productos.Add(new Software(789456, "Microsoft", "9600", TipoSistemaOperativo.Windows, 5600, 5));


            Ventas.Add(new Venta(productos, c1, DateTime.Now));
            Ventas.Add(new Venta(productos, c2, DateTime.Now));
            Ventas.Add(new Venta(productos, c3, DateTime.Now));

        }
    }
}
