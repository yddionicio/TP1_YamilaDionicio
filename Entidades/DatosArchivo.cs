using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Entidades
{
    public class DatosArchivo : IArchivos
    {
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");

        public void WriterLog(Exception ex, string descripcion, string clase, string metodo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine($"Fecha y hora: {DateTime.Now}");
                    writer.WriteLine($"Descripción: {descripcion}");
                    writer.WriteLine($"Clase: {clase}");
                    writer.WriteLine($"Metodo: {metodo}");
                    writer.WriteLine($"Excepcíón: {ex.ToString()}");
                    writer.WriteLine();
                }
            }
            catch (Exception e)
            {
                throw new CrearArchivoException("Error al crear el archivo .txt", e);
            }
        }


        public void WriteXml(List<Producto> productos, Cliente cliente) 
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("venta.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Venta));

                    Venta venta = new Venta(productos, cliente, DateTime.Now);
                    xmlSerializer.Serialize(streamWriter, venta);
                }
            }
            catch (Exception e)
            {
                throw new CrearArchivoException("Error al crear el archivo .xml", e);
            }
        }


        public Configuracion LeerJson(string ruta)
        {
            try
            {
                string contenido = File.ReadAllText(ruta);
                return JsonSerializer.Deserialize<Configuracion>(contenido);
            }
            catch (Exception e)
            {
                throw new CrearArchivoException("Error al crear el archivo .json", e);
            }

        }

    }
}
