using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T>
    {
        List<T> leerJson(string path);
        //List<T> leerXml(string path);
        //List<T> leerTxt(string path);

    }
}
