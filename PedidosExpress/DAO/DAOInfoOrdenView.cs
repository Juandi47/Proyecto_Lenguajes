using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TO;

namespace DAO
{
    public class DAOInfoOrdenView
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString);

        DataTable tabla = new DataTable();
        List<TOInfoOrdenView> listaTO = new List<TOInfoOrdenView>();



        public List<TOInfoOrdenView> ListaOrdenes() {

            string query = "select * from InfoOrdenView;";

            SqlDataAdapter adapter = new SqlDataAdapter(query,conexion);
            

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows) {
                listaTO.Add(new TOInfoOrdenView(x["Cedula"].ToString(), x["Nombre"].ToString(), x["Apellido1"].ToString(), x["Apellido2"].ToString(), Int32.Parse(x["Codigo_Orden"].ToString()), x["Codigo_Plato"].ToString(), x["Nombre_Plato"].ToString(), Int32.Parse(x["Cantidad"].ToString()), x["Hora"].ToString()));
            }            
            return listaTO;
        }


        public List<TOInfoOrdenView> ListaOrdenesCliente(string cedula) {
            string query = "select * from Orden where Cedula = @ced";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@ced", cedula);
            return listaTO;
        }
        
    }
}
