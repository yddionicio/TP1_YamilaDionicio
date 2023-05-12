using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public enum TipoPago { Credito, Debito }

        private DateTime fecha;
        private Producto producto;
        private List<Producto> listaProdSeleccionados;
        private Cliente cliente;
        private int dinero;
        private int cantidad;
        private TipoPago tipoPago;
        private double precioFinal;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Producto> ListaProdSeleccionados { get => listaProdSeleccionados; set => listaProdSeleccionados = value; }


        public Venta(List<Producto> productos, Cliente cliente, DateTime fecha)
        {
            this.ListaProdSeleccionados = productos;
            //this.tipoPago = pago;
            this.Cliente = cliente;
            this.Fecha = fecha;
        }


        public static int SimuladorDinero()
        {
            Random rdm = new Random();
            return rdm.Next(2000, 8000);
        }

        public static double CalcularSubtotalPorPrecio(double precio, int cantidad)
        {
            double totalFinal;
            totalFinal = precio * cantidad;
            return totalFinal;
        }

        public static double CalcularSubtotal(List<Producto> listaProdSeleccion)
        {
            double total = 0;
            foreach (Producto item in listaProdSeleccion)
            {
                double subTotal = CalcularSubtotalPorPrecio(item.Precio, item.Cantidad);
                total += subTotal;
            }
            return total;
        }

        public static double PrecioFinalConDescuento(double subtotal)
        {
            double precioConDescuento, descuento;

            descuento = subtotal * 0.1;
            precioConDescuento = subtotal - descuento;
            return precioConDescuento;
        }

        public static double PrecioFinalConRecargo(double subtotal)
        {
            double precioConRecargo, recargo;

            recargo = subtotal * 0.1;
            precioConRecargo = subtotal + recargo;
            return precioConRecargo;
        }

        public static double CalcularPrecioFinal(TipoPago tipo, string nombre, double subtotal)
        {
            double total = 0;
            if (subtotal != 0)
            {
                if (TipoPago.Debito == tipo)
                {
                    total = PrecioFinalConDescuento(subtotal);
                    nombre += "Descuento 10%";
                }
                else
                {
                    total = PrecioFinalConRecargo(subtotal);
                    nombre += "Recargo 10%";
                }
            }
            return total;
        }

        public static void CalcularVenta(int cantidad, TipoPago tipo, double precio)
        {
            //this.producto.Cantidad -= cantidad;
            //CalcularPrecioFinal(tipo, precio, cantidad);
        }


    }
}
