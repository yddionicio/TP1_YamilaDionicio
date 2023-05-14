using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private string email;
        private int telefono;

        public Cliente(string nombre, string apellido, int dni, string email, int telefono): base(nombre, apellido, dni)
        {
            Email = email;
            this.Telefono = telefono;
        }

        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }


        public override string Mostrar()
        {
            string cadena = $"DATOS CLIENTE: \n{base.Mostrar()} Mail: {this.email} \nTelefono: {this.telefono}\n";
            return cadena;
        }



    }
}
