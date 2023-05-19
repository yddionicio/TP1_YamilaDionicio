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

        public TipoRol Rol
        {
            get { return this.rol; }
            set { this.rol = value; } 
        }

        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }

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
