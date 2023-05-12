using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public enum TipoRol { Vendedor, Supervisor}
        public TipoRol rol;


        public Usuario(string nombre, int dni, TipoRol tipoRol) : base(nombre, dni)
        {
            this.rol = tipoRol;
        }


    }
}
