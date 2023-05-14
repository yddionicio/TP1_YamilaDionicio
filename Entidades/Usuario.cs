using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public TipoRol rol;


        public Usuario(string nombre, string apellido, int dni, TipoRol tipoRol) : base(nombre, apellido, dni)
        {
            this.rol = tipoRol;
        }


    }
}
