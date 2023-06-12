﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDatos : DatosDAO
    {

        public delegate void CompraRealizadaEventHandler();
        public event CompraRealizadaEventHandler CompraRealizada;


        public void RealizarCompra()
        {
            Thread.Sleep(5000);
            CompraRealizada.Invoke();
        }


        public List<Producto> AgregarProducto(List<Producto> listaProductos, List<Producto> listaSeleccionado, out bool productoEncontrado, decimal cantidad)
        {
            productoEncontrado = false;
            Producto productoSeleccionado = null;

            foreach (Producto item in listaProductos)
            {
                productoSeleccionado = new Producto(item.Codigo, item.Descripcion, item.Precio, (int)cantidad);

                productoEncontrado = false;

                foreach (Producto producto in listaSeleccionado)
                {
                    if (producto == productoSeleccionado)
                    {
                        productoEncontrado = true;
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    listaSeleccionado += productoSeleccionado;
                    productoEncontrado = true;
                    break;
                }
            }

            return listaSeleccionado;
        }



    }
}