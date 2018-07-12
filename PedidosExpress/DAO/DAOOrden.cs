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
    public class DAOOrden
    {

        private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private SqlCommand sentencia;
        private SqlTransaction transa;



        private void establecerConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            sentencia = conexion.CreateCommand();
            transa = conexion.BeginTransaction();
        }

        public bool insertarOrden(int codigo_Orden, DateTime fecha_Hora, string cedula, string estado_Pedido, double costo_Total)
        {
            establecerConexion();

            //try
            //{
            sentencia.Transaction = transa;
            sentencia.Connection = conexion;

            sentencia.CommandText = "Insert into Orden(codigo_Orden, [Fecha/Hora_pedido], cedula, Estado_pedido, Costo_total) values(@codigo_Orden, @fecha_hora_pedido, @cedula, @estadoPedido, @costoTotal)";
            sentencia.Parameters.AddWithValue("@codigo_Orden", codigo_Orden);
            sentencia.Parameters.AddWithValue("@fecha_hora_pedido", fecha_Hora);
            sentencia.Parameters.AddWithValue("@cedula", cedula);
            sentencia.Parameters.AddWithValue("@estadoPedido", estado_Pedido);
            sentencia.Parameters.AddWithValue("@costoTotal", costo_Total);


            sentencia.ExecuteNonQuery();
            transa.Commit();
            return true;



            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());

            //}

            //conexion.Close();
            //return false;
        }

        public void modificarLapso(int lapso)
        {
            establecerConexion();

            sentencia.Transaction = transa;
            sentencia.Connection = conexion;

            sentencia.CommandText = "UPDATE Configuraciones SET Minutos_max_orden= @lapso";
            sentencia.Parameters.AddWithValue("@lapso", lapso);

            sentencia.ExecuteNonQuery();
            transa.Commit();
        }


        public void eliminarOrden(int Codigo_orden)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                sentencia.CommandText = " DELETE FROM Orden WHERE Codigo_orden=@codigo_Orden;";
                sentencia.Parameters.AddWithValue("@codigo_Orden", Codigo_orden.ToString());


                sentencia.ExecuteNonQuery();
                transa.Commit();



            }
            catch (Exception ex)
            {
                Console.WriteLine("La orden no existe");
            }
            conexion.Close();
        }



        public TOOrden buscarOrden(int Codigo_orden)
        {
            TOOrden toOrden = new TOOrden();
            establecerConexion();

            //try
            //{
            sentencia.Transaction = transa;
            sentencia.Connection = conexion;


            sentencia.CommandText = "SELECT Codigo_orden, [Fecha/Hora_pedido] , Cedula, Estado_pedido, Costo_total FROM Orden WHERE Codigo_orden=@codigo_Orden;";
            sentencia.Parameters.AddWithValue("@codigo_Orden", Codigo_orden.ToString());


            using (SqlDataReader reader = sentencia.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        toOrden.Codigo_Orden = int.Parse(reader["Codigo_orden"].ToString());
                        //toOrden.Fecha_Hora = Convert.ToDateTime(reader["Fecha/Hora_pedido"].ToString());
                        toOrden.Cedula = reader["Cedula"].ToString();
                        toOrden.Estado_Pedido = reader["Estado_pedido"].ToString();
                        toOrden.Costo_Total = double.Parse(reader["Costo_total"].ToString());
                    }
                }
                else
                {
                    toOrden.Codigo_Orden = 0;
                    toOrden.Cedula = "";
                    toOrden.Estado_Pedido = "";
                    toOrden.Costo_Total = 0;
                }


            }




            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());

            conexion.Close();
            return toOrden;
        }




        public void modificarOrden(int codigo_Orden, DateTime fecha_Hora, string cedula, string estado_Pedido, double costo_Total)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;
                sentencia.CommandText = "UPDATE Orden SET Codigo_orden = @codigo_Orden, Fecha/Hora_pedido=@fecha_hora_pedido, Cedula=@cedula, Estado_pedido=@estadoPedido, Costo_total=@costoTotal WHERE Codigo_orden=@codigo_Orden";
                sentencia.Parameters.AddWithValue("@codigo_Orden", codigo_Orden);
                sentencia.Parameters.AddWithValue("@fecha_hora_pedido", fecha_Hora);
                sentencia.Parameters.AddWithValue("@cedula", cedula);
                sentencia.Parameters.AddWithValue("@estadoPedido", estado_Pedido);
                sentencia.Parameters.AddWithValue("@costoTotal", costo_Total);

                sentencia.ExecuteNonQuery();
                transa.Commit();



            }
            catch (Exception ex)
            {
                Console.WriteLine("La orden no existe");
            }
            conexion.Close();
        }



    }
}
