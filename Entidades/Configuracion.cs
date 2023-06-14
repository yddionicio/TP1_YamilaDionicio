using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Configuracion
    {
        private string imagen;
        private string color;
        private string fuente;
        private string fondo;
        private string sonido;

        public string Imagen { get => imagen; set => imagen = value; }
        public string Color { get => color; set => color = value; }
        public string Fuente { get => fuente; set => fuente = value; }
        public string Sonido { get => sonido; set => sonido = value; }
        public string Fondo { get => fondo; set => fondo = value; }

        public Configuracion(string imagen, string color, string fuente, string sonido, string fondo)
        {
            this.imagen = imagen;
            this.color = color;
            this.fuente = fuente;
            this.sonido = sonido;
            this.fondo = fondo;
        }
    }
}
