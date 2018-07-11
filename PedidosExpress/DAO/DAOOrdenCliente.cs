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
    public class DAOOrdenCliente
    {
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.ConnectionString);

        public List<TOOrdenCliente> ordenesClientes() {
            List<TOOrdenCliente> lista = new List<TOOrdenCliente>();

            string query = "SELECT Cedula, Nombre, Apellido1, Apellido2, Correo, Contrasenna, Estado_cliente, Codigo_postal, Nombre_usuario, Codigo_Orden, datetime(Fecha_Hora) as date, Cedula, Estado_Pedido, Costo_Total  FROM cliente C, Orden O WHERE C.Cedula = O.Cedula; ";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOOrdenCliente((new TOCliente(reader["Cedula"].ToString(), reader["Nombre"].ToString(),
                       reader["Apellido1"].ToString(), reader["Apellido2"].ToString(), reader["Correo"].ToString(),
                       reader["Contrasenna"].ToString(), Int32.Parse(reader["Estado_cliente"].ToString()),
                       reader["Codigo_postal"].ToString(), reader["Nombre_usuario"].ToString())),
                       (new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       Convert.ToDateTime(reader["Fecha_Hora"].ToString()), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())))));
                    //arreglar la fecha
                }

            }
            else {
               // lista.Add(new TOOrdenCliente(new TOCliente("", "", "", "", "", "", 0, "", ""), new TOOrden(0, "", "", "", 0)));
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
           

            return lista;
        }

    }
}
