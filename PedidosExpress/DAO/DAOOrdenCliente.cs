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

        public List<TOOrdenCliente> ordenesClientes()
        {
            List<TOOrdenCliente> lista = new List<TOOrdenCliente>();
            string estadoCliente;

            string query = "SELECT *  FROM cliente C, Orden O WHERE C.Cedula = O.Cedula; ";

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
                    if ((Int32.Parse(reader["Estado_cliente"].ToString()) > 0))
                    {
                        estadoCliente = "bloqueado";
                    }
                    else {
                        estadoCliente = "desbloqueado";
                    }

                    lista.Add(new TOOrdenCliente(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString()),
                       reader["Cedula"].ToString(), reader["Nombre"].ToString(),
                       reader["Apellido1"].ToString(), reader["Apellido2"].ToString(), reader["Correo"].ToString(),
                       reader["Contrasenna"].ToString(), estadoCliente,
                       reader["Codigo_postal"].ToString(), reader["Nombre_usuario"].ToString()));

                }

            }
            else {
                lista.Add(new TOOrdenCliente(0, "", "", 0, "", "", "", "", "", "", "", "", ""));
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }


            return lista;
        }

        public List<TOOrden> buscarPedidosCliente(string cedula)
        {
            List<TOOrden> listaTO = new List<TOOrden>();

            string query = "SELECT * FROM Orden WHERE Cedula = @ced; ";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@ced", cedula);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaTO.Add(new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())));
                }
            }


            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return listaTO;
        }


        public List<TOOrden> buscarPedidosPorFecha(List<string> fechas)
        {
            List<TOOrden> listaOrden = new List<TOOrden>();
            string fecha1 = fechas[0];
            string fecha2 = fechas[1];

            string query = "select * from Orden where CONVERT(varchar(10),[Fecha/Hora_pedido],111) between @fecha1 and @fecha2;";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@fecha1", fecha1);
            comand.Parameters.AddWithValue("@fecha2", fecha2);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaOrden.Add(new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())));
                }
            }


            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return listaOrden;
        }

        public List<TOOrden> buscarPedidosClientePorFecha(List<string> fechas, string cedula)
        {
            List<TOOrden> listaOrden = new List<TOOrden>();
            string fecha1 = fechas[0];
            string fecha2 = fechas[1];

            string query = "select * from Orden where CONVERT(varchar(10),[Fecha/Hora_pedido],111) between @fecha1 and @fecha2 and Cedula = @ced;";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@fecha1", fecha1);
            comand.Parameters.AddWithValue("@fecha2", fecha2);
            comand.Parameters.AddWithValue("@ced", cedula);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaOrden.Add(new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())));
                }
            }


            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return listaOrden;
        }



        public List<TOOrden> buscarPedidosEstado(string estado)
        {
            List<TOOrden> listaOrden = new List<TOOrden>();

            string query = "select * from Orden where Estado_pedido = @estado; ";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@estado", estado);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaOrden.Add(new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())));
                }
            }


            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return listaOrden;
        }



        public List<TOOrden> buscarPedidosClienteEstado(string estado, string cedula)
        {
            List<TOOrden> listaOrden = new List<TOOrden>();

            string query = "select * from Orden where Estado_pedido = @estado and Cedula = @ced; ";

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@estado", estado);
            comand.Parameters.AddWithValue("@ced", cedula);
            SqlDataReader reader = comand.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaOrden.Add(new TOOrden(Int32.Parse(reader["Codigo_Orden"].ToString()),
                       reader["Fecha/Hora_pedido"].ToString(), reader["Cedula"].ToString(),
                       reader["Estado_Pedido"].ToString(), Convert.ToDouble(reader["Costo_Total"].ToString())));
                }
            }


            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return listaOrden;
        }


        public int cambiarEstadoOrden(string codigo, string estado)
        {
           int filasAfectadas;

            string query = "UPDATE Orden SET Estado_pedido = @estado where Codigo_Orden = @cod" ;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@estado", estado);
            comand.Parameters.AddWithValue("@cod", codigo);
            filasAfectadas = comand.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return filasAfectadas;
        }

        
    }
}
