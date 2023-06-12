using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class DatosArchivo : IArchivos
    {
        private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");


        public void WriterLog(Exception ex, string descripcion, string clase, string metodo)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"Fecha y hora: { DateTime.Now}");  
                writer.WriteLine($"Descripción: { descripcion}");  
                writer.WriteLine($"Clase: {clase}");  
                writer.WriteLine($"Metodo: {metodo}");  
                writer.WriteLine($"Excepcíón: {ex.ToString()}");
                writer.WriteLine();
            }
        }



    }
}
