using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TraerDatosException : Exception
    {
        public TraerDatosException(string mensaje, Exception inner) : base(mensaje, inner)
        {
            string logMensaje = $"{DateTime.Now}: {mensaje}";
            RegistrarLog(logMensaje);
        }

        private void RegistrarLog(string error)
        {
            string path = "mensajeError.log";
            System.IO.File.AppendAllText(path, error);
        }
    }
}
