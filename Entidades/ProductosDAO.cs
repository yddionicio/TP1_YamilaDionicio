using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosDAO: DBContexto, IDbAcciones<Producto>
    {
        public void Add(Producto obj)
        {
            try
            {
                string consulta = "";

                if (obj is Software)
                {
                    consulta = "INSERT INTO Software (Codigo, Descripcion, version, TipoSistemaOperativo, Precio, Cantidad) " +
                               "VALUES (@Codigo, @Descripcion, @version, @tipoSistemaOperativo, @Precio, @Cantidad)";
                }
                else if (obj is Hardware)
                {
                    consulta = "INSERT INTO Hardware (Codigo, Descripcion, Capacidad, TipoConexion, Precio, Cantidad) " +
                               "VALUES (@Codigo, @Descripcion, @Capacidad, @TipoConexion, @Precio, @Cantidad)";
                }

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@Codigo", obj.Codigo);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                comando.Parameters.AddWithValue("@Precio", obj.Precio);
                comando.Parameters.AddWithValue("@Cantidad", obj.Stock);

                if (obj is Software)
                {
                    Software software = (Software)obj;
                    comando.Parameters.AddWithValue("@version", software.Version);
                    comando.Parameters.AddWithValue("@tipoSistemaOperativo", software.TipoSistemaOperativo.ToString());
                }
                else if (obj is Hardware)
                {
                    Hardware hardware = (Hardware)obj;
                    comando.Parameters.AddWithValue("@Capacidad", hardware.Capacidad);
                    comando.Parameters.AddWithValue("@TipoConexion", hardware.TipoConexion.ToString());
                }

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al insertar el producto.", e);
            }
        }


        public List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                conexion.Open();

                // Consulta para obtener los datos de la tabla "Software"
                string consultaSoftware = "SELECT * FROM Software";
                ConfigurarComando(consultaSoftware, CommandType.Text);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Software(
                                                int.Parse(reader[0].ToString()),
                                                reader[1].ToString(),
                                                reader[2].ToString(),
                                                (TipoSistemaOperativo)Enum.Parse(typeof(TipoSistemaOperativo), reader[3].ToString()),
                                                double.Parse(reader[4].ToString()),
                                                int.Parse(reader[5].ToString())
                                             ));
                }

                reader.Close();

                // Consulta para obtener los datos de la tabla "Hardware"
                string consultaHardware = "SELECT * FROM Hardware";
                ConfigurarComando(consultaHardware, CommandType.Text);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Hardware(
                                                int.Parse(reader[0].ToString()),
                                                reader[1].ToString(),
                                                int.Parse(reader[2].ToString()),
                                                (TipoConexion)Enum.Parse(typeof(TipoConexion), reader[3].ToString()),
                                                double.Parse(reader[4].ToString()),
                                                int.Parse(reader[5].ToString())
                                            ));

                }

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al leer los productos.", e);
            }

            return productos;
        }

        public void Delete(int codigo)
        {
            try
            {
                string consultaSoftware = "DELETE FROM Software WHERE Codigo = @codigo";

                conexion.Open();
                ConfigurarComando(consultaSoftware, CommandType.Text);
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@codigo", codigo);
                int filasAfectadasSoftware = comando.ExecuteNonQuery();

                string consultaHardware = "DELETE FROM Hardware WHERE Codigo = @codigo";

                ConfigurarComando(consultaHardware, CommandType.Text);
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@codigo", codigo);
                int filasAfectadasHardware = comando.ExecuteNonQuery();

                conexion.Close();

                if (filasAfectadasSoftware == 0 && filasAfectadasHardware == 0)
                {
                    throw new Exception("No se encontró ningún producto con el código especificado.");
                }
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al eliminar el producto.", e);
            }
        }

        public void Update(Producto obj)
        {
            string tabla;

            if (obj is Software)
            {
                tabla = "Software";
            }
            else if (obj is Hardware)
            {
                tabla = "Hardware";
            }
            else
            {
                throw new ArgumentException("Tipo de producto no válido");
            }

            using (SqlConnection connection = new SqlConnection("cadenaDeConexion"))
            {
                connection.Open();

                string consulta = $"UPDATE {tabla} SET Stock = @nuevoStock WHERE Id = @productoId";

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@nuevoStock", obj.Stock);
                    command.Parameters.AddWithValue("@productoId", obj.Codigo);

                    ConfigurarComando(consulta, CommandType.Text);
                    command.ExecuteNonQuery();
                }

            }
        }




    }
}
