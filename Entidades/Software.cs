using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoSistemaOperativo { Windows, Linux, MacOs }
    public class Software : Producto
    {
        private string version;
        private TipoSistemaOperativo tipoSistemaOperativo;

        public string Version { get => version; set => version = value; }
        public TipoSistemaOperativo TipoSistemaOperativo { get => tipoSistemaOperativo; set => tipoSistemaOperativo = value; }

        public Software(int codigo, string descripcion, string version, TipoSistemaOperativo tipoSistemaOperativo, double precio, int cantidad) :
            base(codigo, descripcion, precio, cantidad)
        {
            this.Version = version;
            this.TipoSistemaOperativo = tipoSistemaOperativo;
        }
    }
}
