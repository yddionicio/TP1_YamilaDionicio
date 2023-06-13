using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Software : Producto
    {
        private string version;
        private TipoSistemaOperativo tipoSistemaOperativo;

        public string Version 
        {
            get { return this.version; }
            set { this.version = value; }
        }
        public TipoSistemaOperativo TipoSistemaOperativo { get => tipoSistemaOperativo; set => tipoSistemaOperativo = value; }

        public Software()
        {
        }

        public Software(int codigo, string descripcion, string version, TipoSistemaOperativo tipoSistemaOperativo, double precio, int cantidad) :
            base(codigo, descripcion, precio, cantidad)
        {
            this.Version = version;
            this.TipoSistemaOperativo = tipoSistemaOperativo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Version: " + this.version);
            sb.AppendLine("Tipo de Sistema Operativo: " + this.tipoSistemaOperativo);
            sb.AppendLine();

            return sb.ToString();
        }

    }
}
