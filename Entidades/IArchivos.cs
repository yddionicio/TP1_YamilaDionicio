using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos
    {
         void WriterLog(Exception ex, string descripcion, string clase, string metodo);
         void WriteXml(List<Producto> productos, Cliente cliente);

        //List<T> leerTxt(string path);

    }
}
