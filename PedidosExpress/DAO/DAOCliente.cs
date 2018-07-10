using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAOCliente
    {

        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.ConnectionString);
        TOCliente cliente = new TOCliente();
        List<TOCliente> listaClientes = new List<TOCliente>();

        public List<TOCliente> listaCliente()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            string query = "select * from Cliente";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read()) {
                    listaClientes.Add(new TOCliente(reader["Cedula"].ToString(), reader["Nombre"].ToString(),
                        reader["Apellido1"].ToString(), reader["Apellido2"].ToString(), reader["Correo"].ToString(),
                        reader["Contrasenna"].ToString(), Int32.Parse(reader["Estado_cliente"].ToString()), reader["Codigo_postal"].ToString(),
                        reader["Nombre_usuario"].ToString()));
                }
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return listaClientes;
        }


        public TOCliente buscarCliente(string cedula) {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            string query = "select * from Cliente where Cedula = @ced";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@ced", cedula);

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.cedula = reader["Cedula"].ToString();
                    cliente.nombre = reader["Nombre"].ToString();
                    cliente.apellido1 = reader["Apellido1"].ToString();
                    cliente.apellido2 = reader["Apellido2"].ToString();
                    cliente.correo = reader["Correo"].ToString();
                    cliente.contrasenna = reader["Contrasenna"].ToString();
                    cliente.estadoCliente = Int32.Parse(reader["Estado_cliente"].ToString());
                    cliente.codigoPostal = reader["Codigo_postal"].ToString();
                    cliente.nombreUsuario = reader["Nombre_usuario"].ToString();
                }

            }
            else {
                cliente.cedula = "";
                cliente.nombre = "";
                cliente.apellido1 = "";
                cliente.apellido2 = "";
                cliente.correo = "";
                cliente.contrasenna = "";
                cliente.estadoCliente = -1;
                cliente.codigoPostal = "";
                cliente.nombreUsuario = "";
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }


            return cliente;

        }

        public int bloquearCliente(string cedula) {
            int modificado;
            int estado = 1;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            string query = "UPDATE Cliente set Estado_cliente = @est WHERE Cedula = @ced;";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@ced", cedula);
            comand.Parameters.AddWithValue("@est", estado);

            int reader = comand.ExecuteNonQuery();
            modificado = reader;

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return modificado;

        }

        public int desbloquearCliente(string cedula)
        {
            int modificado;
            int estado = 0;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            string query = "UPDATE Cliente set Estado_cliente = @est WHERE Cedula = @ced;";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@ced", cedula);
            comand.Parameters.AddWithValue("@est", estado);

            int reader = comand.ExecuteNonQuery();
            modificado = reader;

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return modificado;

        }

        public void RegistrarCliente(String cedula, String Nombre, String Apellido1, String Apellido2, String correo, String contrasenna, String CodPostal, String NombreUsuario, String Provincia, String Canton, String Distrito) {

            DAODireccion direccion = new DAODireccion();

            direccion.IngresarDireccion(CodPostal, Provincia, Canton, Distrito);

            String query = "Insert into Cliente values(@ced,@nomb,@ape1,@ape2,@cor,@cont,0,@cod,@nombUs);";

            SqlCommand comando = new SqlCommand(query,conexion);

            comando.Parameters.AddWithValue("@ced", cedula);
            comando.Parameters.AddWithValue("@nomb", Nombre);
            comando.Parameters.AddWithValue("@ape1", Apellido1);
            comando.Parameters.AddWithValue("@ape2", Apellido2);
            comando.Parameters.AddWithValue("@cor", correo);
            comando.Parameters.AddWithValue("@cont", contrasenna);
            comando.Parameters.AddWithValue("@cod", CodPostal);
            comando.Parameters.AddWithValue("@nombUs", NombreUsuario);

            if (ConnectionState.Open != conexion.State)
            {
                conexion.Open();
            }

            comando.ExecuteNonQuery();

            if (ConnectionState.Closed != conexion.State)
            {
                conexion.Close();
            }

        }
           
    }
}
