using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuariosDAO : DBContexto, IDbAcciones<Usuario>
    {
        public void Add(Usuario obj)
        {
            string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Dni, TipoRol, Email) VALUES (@Nombre, @Apellido, @Dni, @TipoRol, @Email)";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj.Apellido);
                comando.Parameters.AddWithValue("@Dni", obj.Dni);
                comando.Parameters.AddWithValue("@TipoRol", obj.Rol.ToString());
                comando.Parameters.AddWithValue("@Email", obj.Mail);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al insertar el usuario.", e);
            }
        }

        public void Delete(int dni)
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

        public List<Usuario> GetAll()
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

        public void Update(Usuario obj)
        {
            try
            {
                string consulta = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, TipoRol = @TipoRol, Email = @Email WHERE Dni = @Dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj.Apellido);
                comando.Parameters.AddWithValue("@Dni", obj.Dni);
                comando.Parameters.AddWithValue("@TipoRol", obj.Rol.ToString());
                comando.Parameters.AddWithValue("@Email", obj.Mail);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Error al actualizar el usuario.", e);
            }
        }
    }
}
