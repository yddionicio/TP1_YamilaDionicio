using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DBContexto
    {
        public SqlCommand comando;
        public SqlConnection conexion;
        public SqlDataReader reader;
        List<Producto> productos;

        public DBContexto()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data source = (LocalDb)\\test; Database = PlataformaVentas; Trusted_Connection = True;");
        }

        public void ConfigurarComando(string consulta, CommandType tipoComando)
        {
            comando.CommandText = consulta;
            comando.Connection = conexion;
            comando.CommandType = tipoComando;
            comando.Parameters.Clear();
        }

    }
}
