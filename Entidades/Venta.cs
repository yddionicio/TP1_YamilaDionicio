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
        private int dinero;
        private int cantidad;
        private TipoPago tipoPago;
        private double precioFinal;


        public Venta(Producto producto, int dinero, int cantidad, TipoPago pago)
        {
            this.producto = producto;   
            this.dinero = dinero;   
            this.cantidad = cantidad;       
            this.tipoPago = pago;       
        }








    }
}
