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

            string query = "select top 5 * from InfoOrdenView where [Estado_pedido] <> 'Entregado' and [Estado_pedido] <> 'Anulado' order by [Fecha/Hora_pedido] desc;";

            SqlDataAdapter adapter = new SqlDataAdapter(query,conexion);
            

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows) {
                //ORDEN
                TOInfoOrdenView orden = new TOInfoOrdenView(Int32.Parse(x["Codigo_Orden"].ToString()), x["Cedula"].ToString(), x["Nombre"].ToString(), x["Apellido1"].ToString(), x["Apellido2"].ToString(), x["Estado_pedido"].ToString(), x["Fecha/Hora_pedido"].ToString());

                //DETALLES DE ORDEN
                SqlDataAdapter adpDetalles = new SqlDataAdapter("select * from detallesOrdenView where Codigo_Orden= @code", conexion);
                DataTable tablaD = new DataTable();
                adpDetalles.SelectCommand.Parameters.AddWithValue("@code", orden.Codigo_Orden);
                adpDetalles.Fill(tablaD);

                foreach (DataRow d in tablaD.Rows)
                {

                    TODetalleOrden det = new TODetalleOrden(Int32.Parse(d["Codigo_Orden"].ToString()), d["Codigo_plato"].ToString(), d["Nombre_plato"].ToString(), Int32.Parse(d["Cantidad"].ToString()), Double.Parse(d["Cantidad"].ToString()));
                    orden.detalles.Add(det);
                }

                //añade la orden tras agregarle los detalles
                listaTO.Add(orden);

            }            
            return listaTO;
        }

        public void entregarOrden(int codigo_Orden)
        {

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlCommand cmd = new SqlCommand("update Orden set Estado_pedido = 'Entregado' where Codigo_orden = @code;", conexion);
            cmd.Parameters.AddWithValue("@code", codigo_Orden);

            cmd.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

        }

        public void actualizarEstado(int codigo_Orden, string estado)
        {
            if (conexion.State != ConnectionState.Open) {
                conexion.Open();
            }

            SqlCommand cmd = new SqlCommand("update Orden set Estado_pedido = @estado where Codigo_orden = @code;", conexion);
            cmd.Parameters.AddWithValue("@code", codigo_Orden);
            cmd.Parameters.AddWithValue("@estado", estado);


            cmd.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

        }
    }
}
