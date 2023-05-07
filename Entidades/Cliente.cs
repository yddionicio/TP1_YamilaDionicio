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

        public Cliente(string nombre, int dni, string email, int telefono): base(nombre, dni)
        {
            Email = email;
            this.Telefono = telefono;
        }

        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
