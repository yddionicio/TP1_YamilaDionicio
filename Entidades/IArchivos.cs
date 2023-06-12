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
        //List<T> leerXml(string path);
        //List<T> leerTxt(string path);

    }
}
