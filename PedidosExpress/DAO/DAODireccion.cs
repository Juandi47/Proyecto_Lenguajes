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

            Boolean existencia = validarCodPostal(CodPostal);
            if  (existencia) {
                return;
            }

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

        public Boolean validarCodPostal(String CodPostal) {

            String query = "select count(*) from Direccion where Codigo_Postal = @cod;";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@cod", CodPostal);

            int existencia = 0;

            if (ConnectionState.Open != conexion.State)
            {
                conexion.Open();
            }

            existencia = Int32.Parse(comando.ExecuteScalar().ToString());

            if (ConnectionState.Closed != conexion.State)
            {
                conexion.Close();
            }

            return existencia!=0 ? true : false;

        }

    }
}
