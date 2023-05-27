using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ProductoDato : Cargar<Producto>
    {

        public ProductoDato() : base(PlataformaVentas.Productos)
        {
        }



    }
}
