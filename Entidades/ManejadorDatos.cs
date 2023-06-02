using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDatos: DatosDAO
    {

        public delegate void CompraRealizadaEventHandler();
        public event CompraRealizadaEventHandler CompraRealizada;


        public void RealizarCompra()
        {
            Thread.Sleep(5000);
            CompraRealizada.Invoke();
        }



    }
}
