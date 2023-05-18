using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        private TipoRol rol;
        private string mail;

        public TipoRol Rol { get => rol; set => rol = value; }
        public string Mail { get => mail; set => mail = value; }

        public Usuario(string nombre, string apellido, int dni, TipoRol tipoRol, string mail) : base(nombre, apellido, dni)
        {
            this.Rol = tipoRol;
            this.Mail = mail;
        }


        //public static bool operator ==(Usuario u1, Usuario u2)
        //{
        //    return u1.Apellido == u2.Apellido;  
        //}

        //public static bool operator !=(Usuario u1, Usuario u2)
        //{
        //    return !(u1.Apellido == u2.Apellido);
        //}


    }
}
