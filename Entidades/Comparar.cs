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

                if (comparacion == 0 && x is Cliente clienteX && y is Cliente clienteY)
                {
                    // Comparar por DNI si los objetos son Cliente y la comparación previa es igual a 0
                    return clienteX.Dni.CompareTo(clienteY.Dni);
                }
                return comparacion;
            });
        }
    }
}
