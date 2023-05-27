using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal abstract class Cargar<T>: IOperador<T>
    {
        private List<T> lista;

        public Cargar(List<T> listaElemntos)
        {
            lista = listaElemntos;
        }
        public void CargarElemento(T elemento)
        {
            lista.Add(elemento);
        }

        public void RemoverElemento(T elemento)
        {
            lista.Remove(elemento);
        }


    }
}
