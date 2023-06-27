using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;
        List<Cliente> clientes;
        List<Producto> productos;

        static DatosDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data source = (LocalDb)\\test; Database = PlataformaVentas; Trusted_Connection = True;");
        }

        private void ConfigurarComando(string consulta, CommandType tipoComando)
        {
            comando.CommandText = consulta;
            comando.Connection = conexion;
            comando.CommandType = tipoComando;
        }

        #region Clientes
        public List<Cliente> TraerDatosClientes()
        {
            string consulta = "SELECT * FROM Clientes";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                reader = comando.ExecuteReader();
                clientes = new List<Cliente>();

                while (reader.Read())
                {
                    clientes.Add(new Cliente(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString())));
                }

                conexion.Close();
                return clientes;
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al leer los clientes.", e);
            }
        }


        public void InsertarDatosCliente(Cliente nuevoCliente)
        {
            string consulta = "INSERT INTO Clientes VALUES (@nombre, @apellido, @dni, @email, @telefono)";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@nombre", nuevoCliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", nuevoCliente.Apellido);
                comando.Parameters.AddWithValue("@dni", nuevoCliente.Dni);
                comando.Parameters.AddWithValue("@email", nuevoCliente.Email);
                comando.Parameters.AddWithValue("@telefono", nuevoCliente.Telefono);

                reader = comando.ExecuteReader();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al insertar el cliente.", e);
            }
        }


        public void EliminarDatosCliente(int dni)
        {
            try
            {
                string consulta = "DELETE FROM Clientes WHERE dni = @dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@dni", dni);
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al eliminar el cliente.", e);
            }
        }


        public async Task ActualizarDatosCliente(Cliente cliente)
        {
            try
            {
                string consulta = "UPDATE Clientes SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono WHERE dni = @dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al actualizar el cliente.", e);
            }
        }

        #endregion


        #region Usuarios
        public List<Usuario> TraerDatosUsuarios()
        {
            string consulta = "SELECT * FROM Usuarios";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                reader = comando.ExecuteReader();
                List<Usuario> usuarios = new List<Usuario>();

                while (reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    int dni = int.Parse(reader["Dni"].ToString());
                    TipoRol tipoRol = (TipoRol)Enum.Parse(typeof(TipoRol), reader["TipoRol"].ToString());
                    string mail = reader["Email"].ToString();

                    Usuario usuario = new Usuario(nombre, apellido, dni, tipoRol, mail);
                    usuarios.Add(usuario);
                }

                conexion.Close();
                return usuarios;
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al leer los usuarios.", e);
            }
        }

        public void InsertarDatosUsuario(Usuario nuevoUsuario)
        {
            string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Dni, TipoRol, Email) VALUES (@Nombre, @Apellido, @Dni, @TipoRol, @Email)";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@Nombre", nuevoUsuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", nuevoUsuario.Apellido);
                comando.Parameters.AddWithValue("@Dni", nuevoUsuario.Dni);
                comando.Parameters.AddWithValue("@TipoRol", nuevoUsuario.Rol.ToString());
                comando.Parameters.AddWithValue("@Email", nuevoUsuario.Mail);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al insertar el usuario.", e);
            }
        }

        public void EliminarDatosUsuario(int dni)
        {
            try
            {
                string consulta = "DELETE FROM Usuarios WHERE dni = @Dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Dni", dni);
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al eliminar el usuario.", e);
            }
        }

        public async Task ActualizarDatosUsuario(Usuario usuario)
        {
            try
            {
                string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, TipoRol = @TipoRol, Email = @Email WHERE Dni = @Dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@Dni", usuario.Dni);
                comando.Parameters.AddWithValue("@TipoRol", usuario.Rol.ToString());
                comando.Parameters.AddWithValue("@Email", usuario.Mail);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al actualizar el usuario.", e);
            }
        }

        #endregion




        #region Productos

        public List<Producto> TraerDatosProductos()
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



        public void InsertarDatosProductos(Producto producto)
        {
            try
            {
                string consulta = "";

                if (producto is Software)
                {
                    consulta = "INSERT INTO Software (Codigo, Descripcion, version, TipoSistemaOperativo, Precio, Cantidad) " +
                               "VALUES (@Codigo, @Descripcion, @version, @tipoSistemaOperativo, @Precio, @Cantidad)";
                }
                else if (producto is Hardware)
                {
                    consulta = "INSERT INTO Hardware (Codigo, Descripcion, Capacidad, TipoConexion, Precio, Cantidad) " +
                               "VALUES (@Codigo, @Descripcion, @Capacidad, @TipoConexion, @Precio, @Cantidad)";
                }

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Cantidad", producto.Stock);

                if (producto is Software)
                {
                    Software software = (Software)producto;
                    comando.Parameters.AddWithValue("@version", software.Version);
                    comando.Parameters.AddWithValue("@tipoSistemaOperativo", software.TipoSistemaOperativo.ToString());
                }
                else if (producto is Hardware)
                {
                    Hardware hardware = (Hardware)producto;
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



        public void EliminarDatosProducto(int codigo)
        {
            try
            {
                // Verificar si el producto está en la tabla Software
                string consultaSoftware = "DELETE FROM Software WHERE Codigo = @codigo";

                conexion.Open();
                ConfigurarComando(consultaSoftware, CommandType.Text);
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@codigo", codigo);
                int filasAfectadasSoftware = comando.ExecuteNonQuery();

                // Verificar si el producto está en la tabla Hardware
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



        public async Task ActualizarDatosProducto(Producto producto)
        {
            try
            {
                string consulta = "";

                if (producto is Software)
                {
                    consulta = "UPDATE Software SET descripcion = @descripcion, version = @version, tipoSistemaOperativo = @tipoSistemaOperativo, precio = @precio, cantidad = @cantidad WHERE codigo = @codigo";
                    Software software = (Software)producto;

                    comando.Parameters.AddWithValue("@descripcion", software.Descripcion);
                    comando.Parameters.AddWithValue("@version", software.Version);
                    comando.Parameters.AddWithValue("@tipoSistemaOperativo", software.TipoSistemaOperativo.ToString());
                }
                else if (producto is Hardware)
                {
                    consulta = "UPDATE Hardware SET descripcion = @descripcion, capacidad = @capacidad, tipoConexion = @tipoConexion, precio = @precio, cantidad = @cantidad WHERE codigo = @codigo";
                    Hardware hardware = (Hardware)producto;

                    comando.Parameters.AddWithValue("@descripcion", hardware.Descripcion);
                    comando.Parameters.AddWithValue("@capacidad", hardware.Capacidad);
                    comando.Parameters.AddWithValue("@tipoConexion", hardware.TipoConexion.ToString());
                }

                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@cantidad", producto.Stock);
                comando.Parameters.AddWithValue("@codigo", producto.Codigo);

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al actualizar el producto.", e);
            }
        }



        #endregion


    }
}
