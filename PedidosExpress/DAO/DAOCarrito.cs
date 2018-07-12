using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TO;

namespace DAO
{
    public class DAOCarrito
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString);
        DataTable tabla = new DataTable();
        List<TOInfoOrdenView> listaTO = new List<TOInfoOrdenView>();

        public void agregarCarrito(String cedula, String codPlato)
        {

            string query = "insert into carrito values(@ced,@codPla);";

            SqlCommand command = new SqlCommand(query, conexion);

            command.Parameters.AddWithValue("@ced", cedula);
            command.Parameters.AddWithValue("@codPla", codPlato);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            command.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public List<TOPlato> listaCarrito(String cedula)
        {
            String query = "select Nombre_plato,Plato.Codigo_plato from Carrito inner join Plato on Carrito.Codigo_Plato = Plato.Codigo_Plato where Carrito.cedula = @ced";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.SelectCommand.Parameters.AddWithValue("@ced", cedula);

            adapter.Fill(tabla);

            List<TOPlato> lista = new List<TOPlato>();

            foreach (DataRow x in tabla.Rows)
            {
                TOPlato plato = new TOPlato();
                plato.nombrePlato = x["Nombre_plato"].ToString();
                plato.codigoPlato = x["Codigo_plato"].ToString();
                lista.Add(plato);
            }
            return lista;
        }

        public void borrarCarrito(String codPlato, String cedula)
        {

            string query = "delete top(1) from Carrito where Codigo_plato = @cod and cedula = @ced;";

            SqlCommand command = new SqlCommand(query, conexion);

            command.Parameters.AddWithValue("@ced", cedula);
            command.Parameters.AddWithValue("@cod", codPlato);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            command.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public void guardarPedidos()
        {

        }


    }
}
