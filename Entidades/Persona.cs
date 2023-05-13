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
        private string apellido;
        private int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }  // chequear set
        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }


        public virtual string Mostrar() 
        {
            string cadena = $"Nombre: {this.nombre}\n Apellido: {this.apellido} \n Dni: {this.Dni}\n";
            return cadena;
        }



    }
}
