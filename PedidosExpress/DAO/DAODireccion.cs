using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAODireccion
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void IngresarDireccion(String CodPostal, String Provincia, String Canton, String Distrito) {

            String query = "Insert into Direccion values(@cod,@prov,@cant,@dist);";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@cod", CodPostal);
            comando.Parameters.AddWithValue("@prov", Provincia);
            comando.Parameters.AddWithValue("@cant", Canton);
            comando.Parameters.AddWithValue("@dist", Distrito);

            if (ConnectionState.Open != conexion.State) {
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
