using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoConexion { USB, HDMI, DVI}
    public class Hardware : Producto
    {
        private int capacidad;
        private TipoConexion tipoConexion;

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public TipoConexion TipoConexion { get => tipoConexion; set => tipoConexion = value; }

        public Hardware(int codigo, string descripcion, int capacidad, TipoConexion tipoConexion, double precio, int cantidad): 
            base(codigo, descripcion, precio, cantidad)
        {
            this.Capacidad = capacidad;
            this.TipoConexion = tipoConexion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Capacidad: " + this.capacidad);
            sb.AppendLine("Tipo de Conexion: " + this.tipoConexion);

            return sb.ToString();
        }

    }
}
