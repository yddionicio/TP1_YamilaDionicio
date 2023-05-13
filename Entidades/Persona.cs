using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }  // chequear set
        public int Dni { get => dni; set => dni = value; }
    }
}
