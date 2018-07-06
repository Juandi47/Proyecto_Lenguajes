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
    public class DAOOrden
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString);

        DataTable tabla = new DataTable();

         

        public List<TOOrden> ListaOrdenes() {

            string query = "select * from InfoOrdenView;";

            SqlDataAdapter adapter = new SqlDataAdapter(query,conexion);

            List<TOOrden> listaTO = new List<TOOrden>();

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows) {
                listaTO.Add(new TOOrden(x["Cedula"].ToString(), x["Nombre"].ToString(), x["Apellido1"].ToString(), x["Apellido2"].ToString(), Int32.Parse(x["Codigo_Orden"].ToString()), x["Codigo_Plato"].ToString(), x["Nombre_Plato"].ToString(), Int32.Parse(x["Cantidad"].ToString())));
            }            
            return listaTO;
        }







    }
}
