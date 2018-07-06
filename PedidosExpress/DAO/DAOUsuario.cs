using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    public class DAOUsuario
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

        public void insertarUsuario(TOUsuario toUsuario)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;

                sentencia.CommandText = "Insert into Usuario(Identificacion,Nombre_usuario,contrasenna,rol) values(@Identificacion, @NombreUsuario, @Contrasenna, @Rol)";
                sentencia.Parameters.AddWithValue("@Identificacion", toUsuario.Identificacion);
                sentencia.Parameters.AddWithValue("@NombreUsuario", toUsuario.Nombre);
                sentencia.Parameters.AddWithValue("@Contrasenna", toUsuario.Contrasenna);
                sentencia.Parameters.AddWithValue("@Rol", toUsuario.Rol);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void eliminarUsuario(string identificacion)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                sentencia.CommandText = " DELETE FROM Usuario WHERE Identificacion=@Identificacion";
                sentencia.Parameters.AddWithValue("@Identificacion", identificacion);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }




        public TOUsuario buscarUsuario(string identificacion)
        {
            TOUsuario toUsuario = new TOUsuario(); 
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                sentencia.CommandText = "SELECT  Identificacion,Nombre_usuario,contrasenna,rol FROM Usuario WHERE Identificacion=@Identificacion;";
                sentencia.Parameters.AddWithValue("@Identificacion", identificacion);

                using (SqlDataReader reader = sentencia.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toUsuario.Nombre = reader["Nombre_usuario"].ToString();
                        toUsuario.Contrasenna = reader["Contrasenna"].ToString();
                        toUsuario.Rol = reader["Rol"].ToString();
                    }


                    //sentencia.ExecuteNonQuery();
                    //transa.Commit();

                    
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conexion.Close();
            return toUsuario;
        }

        public void modificarUsuario(string identificacion, string atributo, string nuevoValor)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;

                sentencia.CommandText = " UPDATE Usuario SET @Atributo = @NuevoValor, WHERE Identificacion=@Identificacion;";
                sentencia.Parameters.AddWithValue("@Identificacion", identificacion);
                sentencia.Parameters.AddWithValue("@Atributo", atributo);
                sentencia.Parameters.AddWithValue("@NuevoValor", nuevoValor);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
