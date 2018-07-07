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

        public List<TOOrden> ListaOrdenes() {

            DataTable tabla = new DataTable();
            string query = "select top 5 * from InfoOrdenView order by [Fecha/Hora_pedido] asc;";
            
            SqlDataAdapter adapter = new SqlDataAdapter(query,conexion);
            List<TOOrden> listaTO = new List<TOOrden>();
            

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows) {
                //crea la orden
                TOOrden o = new TOOrden(Int32.Parse(x["Codigo_Orden"].ToString()), x["Cedula"].ToString(), x["Nombre"].ToString(), x["Apellido1"].ToString(), x["Apellido2"].ToString(), x["Estado_pedido"].ToString(), DateTime.Parse(x["Fecha/Hora_pedido"].ToString()));
                
                //crea los detalles de la orden actual
                string cmd = ("select * from detallesOrdenView where (Codigo_orden = @codeO);");
                adapter = new SqlDataAdapter(cmd,conexion);
                adapter.SelectCommand.Parameters.AddWithValue("@codeO", o.Codigo_Orden);
                DataTable tabla2 = new DataTable();
                adapter.Fill(tabla2);

                foreach (DataRow d in tabla2.Rows)
                {
                    o.detallesOrden.Add(new TODetalleOrden(Int32.Parse(d["Codigo_orden"].ToString()), d["Codigo_plato"].ToString(), d["Nombre_plato"].ToString(), Int32.Parse(d["Cantidad"].ToString()), Double.Parse(d["Precio_linea"].ToString())));
                }
                    //añade
                    listaTO.Add(o);
            }            
            return listaTO;
        }







    }
}
