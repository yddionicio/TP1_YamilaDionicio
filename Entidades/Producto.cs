﻿using System;
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

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }


        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.Codigo == producto2.Codigo;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

    }
}