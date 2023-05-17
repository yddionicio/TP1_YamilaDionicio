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
        private static List<Usuario> usuarios = new List<Usuario>();

        static PlataformaVentas() 
        {
            PlataformaVentas.CargarProductos();
            PlataformaVentas.CargarClientes();
            PlataformaVentas.CargarVentas();
            PlataformaVentas.CargarUsuarios();
        }

        public static List<Producto> Productos { get => productos; set => productos = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static List<Venta> Ventas { get => ventas; set => ventas = value; }
        public static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public static void CargarProductos()
        {
            Random rdm = new Random();

            Productos.Add(new Hardware(rdm.Next(200000, 600000), "Monitor", 2000, TipoConexion.HDMI, 1550, 11));
            Productos.Add(new Hardware(rdm.Next(200000, 600000), "Teclado", 2000, TipoConexion.USB, 1000, 5));
            Productos.Add(new Software(rdm.Next(200000, 600000), "Visual", "7.0", TipoSistemaOperativo.MacOs, 3600, 7));
            Productos.Add(new Software(rdm.Next(200000, 600000), "Photoshop", "9.0", TipoSistemaOperativo.Windows, 500, 15));
            Productos.Add(new Software(123456, "Photoshop", "9.0", TipoSistemaOperativo.Windows, 1200, 8));
            Productos.Add(new Software(2222, "aaaaa", "7.0", TipoSistemaOperativo.Linux, 1900, 5));
        }

        public static void CargarClientes()
        {
            Clientes.Add(new Cliente("pompo", "pomposo", 36258147, "pmp@gmail.com", 15926348));
            Clientes.Add(new Cliente("Lucas", "Perez", 32852999, "lp@gmail.com", 1531322525));
            Clientes.Add(new Cliente("Maria", "Garcia", 36111258, "mg@gmail.com", 1511224487));
            Clientes.Add(new Cliente("Tomas", "Martin", 41254456, "tm@gmail.com", 1599652387));
        }

        public static void CargarVentas()
        {
            Random rdm = new Random();
            List<Producto> p1 = new List<Producto>();
            List<Producto> p2 = new List<Producto>();

            Cliente c1 = new Cliente("Gustavo", "Bruno", 36258147, "pmp@gmail.com", 15926348);
            Cliente c2 = new Cliente("Yamila", "Dionicio", 38260999, "ydd@gmail.com", 1532312727);
            Cliente c3 = new Cliente("Juan", "Perez", 36258147, "jp@gmail.com", 1526485923);

            p1.Add(new Hardware(rdm.Next(15000, 600000), "Monitor", 2000, TipoConexion.HDMI, 789000, 5));
            p1.Add(new Hardware(rdm.Next(500, 600000), "Teclado", 900, TipoConexion.USB, 200, 9));
            p2.Add(new Hardware(rdm.Next(8692, 600000), "Mouse", 6000, TipoConexion.DVI, 3600, 2));
            p2.Add(new Software(789456, "Microsoft", "9600", TipoSistemaOperativo.Windows, 5600, 5));

            DateTime fecha1 = new DateTime(2023, 05, 10);
            DateTime fecha2 = new DateTime(2023, 05, 12);
            Ventas.Add(new Venta(p1, c1, DateTime.Now.Date));
            Ventas.Add(new Venta(p1, c2, fecha1));
            Ventas.Add(new Venta(p2, c3, fecha2));
            Ventas.Add(new Venta(p1, c2, fecha2));

        }


        public static void CargarUsuarios()
        {
            usuarios.Add(new Usuario("Nicolas", "Perez", 32654789, TipoRol.Vendedor, "nrod@gmail.com"));
            usuarios.Add(new Usuario("Antonella", "Matinez", 15123456, TipoRol.Vendedor, "amat@gmail.com"));
            usuarios.Add(new Usuario("Pable", "Smith", 42456852, TipoRol.Supervisor, "psmit@gmail.com"));
        }


    }
}
