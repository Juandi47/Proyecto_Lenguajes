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
