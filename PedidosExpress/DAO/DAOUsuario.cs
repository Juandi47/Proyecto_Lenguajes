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
   public  class DAOUsuario
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
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                //sentencia.CommandText = "SELECT  Identificacion,Nombre_usuario,contrasenna,rol FROM Usuario values(@Identificacion, @NombreUsuario, @Contrasenna, @Rol)";
                //sentencia.Parameters.AddWithValue("@Identificacion", TOUsuario.);
                //sentencia.Parameters.AddWithValue("@NombreUsuario", TOUsuario.Nombre);
                //sentencia.Parameters.AddWithValue("@Contrasenna", TOUsuario.Contrasenna);
                //sentencia.Parameters.AddWithValue("@Rol", TOUsuario.Rol);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();
               
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
