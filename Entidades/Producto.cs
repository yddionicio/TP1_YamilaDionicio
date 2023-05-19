using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int codigo;
        private string descripcion;
        private double precio;
        private int cantidad;

        public Producto(int codigo, string descripcion, double precio, int cantidad)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + this.codigo);
            sb.AppendLine("Descripcion: " + this.descripcion);
            sb.AppendLine("Precio: " + this.precio);
            sb.AppendLine("Cantidad: " + this.cantidad);

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (ReferenceEquals(p1, p2))
            {
                return true;
            }

            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            {
                return false;
            }

            return p1.codigo.Equals(p2.codigo);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            bool productoEncontrado = false;

            foreach (Producto item in productos)
            {
                if (item == producto)
                {
                    productoEncontrado = true; 
                    break;
                }
            }

            if (!productoEncontrado)
            {
                productos.Add(producto);
            }
            
            return productos;
        }


    }
}
