using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesDAO : DBContexto, IDbAcciones<Cliente>
    {
        List<Cliente> clientes;

        public void Add(Cliente obj)
        {
            string consulta = "INSERT INTO Clientes VALUES (@nombre, @apellido, @dni, @email, @telefono)";

            try
            {
                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);

                comando.Parameters.AddWithValue("@nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@apellido", obj.Apellido);
                comando.Parameters.AddWithValue("@dni", obj.Dni);
                comando.Parameters.AddWithValue("@email", obj.Email);
                comando.Parameters.AddWithValue("@telefono", obj.Telefono);

                reader = comando.ExecuteReader();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al insertar el cliente.", e);
            }

        }

        public void Delete(int dni)
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

        public List<Cliente> GetAll()
        {

            string consulta = "SELECT * FROM Clientes ORDER BY apellido, nombre";

            try
            {
                conexion.Open();
                base.ConfigurarComando(consulta, CommandType.Text);
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

        public void Update(Cliente obj)
        {
            try
            {
                string consulta = "UPDATE Clientes SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono WHERE dni = @dni";

                conexion.Open();
                ConfigurarComando(consulta, CommandType.Text);
                comando.Parameters.AddWithValue("@nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@apellido", obj.Apellido);
                comando.Parameters.AddWithValue("@dni", obj.Dni);
                comando.Parameters.AddWithValue("@email", obj.Email);
                comando.Parameters.AddWithValue("@telefono", obj.Telefono);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al actualizar el cliente.", e);
            }
        }
    }
}
