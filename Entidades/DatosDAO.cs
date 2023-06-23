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

        #region Productos

        //public List<Producto> TraerDatosProductos()
        //{
        //    string consulta = "SELECT * FROM Productos";

        //    try
        //    {
        //        conexion.Open();
        //        ConfigurarComando(consulta, CommandType.Text);
        //        reader = comando.ExecuteReader();
        //        productos = new List<Producto>();

        //        while (reader.Read())
        //        {
        //            productos.Add(new Producto(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString())));
        //        }

        //        conexion.Close();
        //        return productos;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new TraerDatosException("Error al leer los clientes.", e);
        //    }
        //}


        //public List<Producto> TraerDatosProductos()
        //{
        //    string consulta = "SELECT * FROM Productos";

        //    try
        //    {
        //        conexion.Open();
        //        ConfigurarComando(consulta, CommandType.Text);
        //        reader = comando.ExecuteReader();
        //        productos = new List<Producto>();

        //        while (reader.Read())
        //        {
        //            string tipo = reader["Tipo"].ToString(); // Supongamos que hay una columna "Tipo" en la tabla Productos que indica el tipo de producto

        //            if (tipo == "Software")
        //            {
        //                productos.Add(new Software(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString()), reader["SoftwareSpecificColumn1"].ToString(), reader["SoftwareSpecificColumn2"].ToString()));
        //            }
        //            else if (tipo == "Hardware")
        //            {
        //                productos.Add(new Hardware(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString()), reader["HardwareSpecificColumn1"].ToString(), reader["HardwareSpecificColumn2"].ToString()));
        //            }
        //            else
        //            {
        //                productos.Add(new Producto(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), reader[3].ToString(), int.Parse(reader[4].ToString())));
        //            }
        //        }

        //        conexion.Close();
        //        return productos;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new TraerDatosException("Error al leer los clientes.", e);
        //    }
        //}

        #endregion


    }
}
