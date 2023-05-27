using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface IOperador<T>
    {
        void CargarElemento(T elemento);
        void RemoverElemento(T elemento);


    }
}
