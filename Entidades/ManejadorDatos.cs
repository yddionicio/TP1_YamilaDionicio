﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDatos
    {
        public delegate void MensajeInformacionEventHandler(string mensaje);
        public event MensajeInformacionEventHandler MostrarMensajeInformacion;

        public delegate void CompraRealizadaEventHandler();
        public event CompraRealizadaEventHandler CompraRealizada;

        public event Action CarritoVacio;

        public Predicate<List<Producto>> carritoVacio = (lista) => lista.Count == 0;

        public void RealizarCompra()
        {
            Thread.Sleep(2000);
            CompraRealizada.Invoke();
        }

        public void MostrarMensaje(string mensaje)
        {
            MostrarMensajeInformacion?.Invoke(mensaje);
        }

        public void OnCarritoVacio()
        {
            CarritoVacio?.Invoke();
        }

        public List<Producto> AgregarProducto(Producto p, List<Producto> listaSeleccionado, out bool productoEncontrado, decimal cantidad)
        {
            productoEncontrado = false;
            Producto productoSeleccionado = null;

            p.Stock = (int)cantidad;
            productoSeleccionado = p;

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
                }

            return listaSeleccionado;
        }



    }
}
