using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class AutenticacionException: Exception
    {
        public int CodigoError { get; }

        public AutenticacionException(string mensaje) : base(mensaje)
        {
            CodigoError = GenerarCodigoError();
            RegistrarErrorEnArchivo(CodigoError, mensaje);
        }

        private int GenerarCodigoError()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        private void RegistrarErrorEnArchivo(int codigo, string mensaje)
        {
            string rutaArchivo = "errorAutenticacion.txt";

            try
            {
                string directorio = Path.GetDirectoryName(rutaArchivo);

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    writer.WriteLine($"{DateTime.Now}: Código de error: {codigo} - {mensaje}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar el error de autenticación: {ex.Message}");
            }
        }

    }
}
