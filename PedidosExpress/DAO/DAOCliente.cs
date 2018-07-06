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
        string query;

        public int bloquearCliente(string cedula) {
            int modificado;
            int estado = 1;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            query = "UPDATE Cliente set Estado_cliente = @est WHERE Cedula = @ced;";
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
           
    }
}
