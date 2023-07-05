using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BaseDeDatosException : Exception
    {
        public BaseDeDatosException(string mensaje) : base(mensaje)
        {
        }

        public BaseDeDatosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
            //ashdbkas
        }
    }
}
