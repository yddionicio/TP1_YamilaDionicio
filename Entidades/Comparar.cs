using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comparar<T>
    {
        public delegate int ComparadorDelegate(T x, T y);

        public void Ordenar(List<T> elementos, ComparadorDelegate comparador)
        {
            elementos.Sort((x, y) =>
            {
                int comparacion = comparador(x, y);
                return comparacion;
            });
        }
    }
}
