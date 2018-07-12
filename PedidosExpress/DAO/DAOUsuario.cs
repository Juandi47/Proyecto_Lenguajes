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

        public void insertarUsuario( string nombre, string contrasenna, string rol)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;

                sentencia.CommandText = "Insert into Usuario values(@NombreUsuario, @Contrasenna, @Rol)";
               
                sentencia.Parameters.AddWithValue("@NombreUsuario", nombre);
                sentencia.Parameters.AddWithValue("@Contrasenna", contrasenna);
                sentencia.Parameters.AddWithValue("@Rol", rol);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public void eliminarUsuario(string nombre, string contrasena)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                sentencia.CommandText = " DELETE FROM Usuario WHERE Nombre_usuario=@NombreUsuario AND Contrasenna=@Contrasena";
                sentencia.Parameters.AddWithValue("@NombreUsuario", nombre);
                sentencia.Parameters.AddWithValue("@Contrasena", contrasena);

                sentencia.ExecuteNonQuery();
                transa.Commit();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        public TOUsuario buscarUsuario(string nombre, string contrasenna)
        {
            TOUsuario toUsuario = new TOUsuario();
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;


                sentencia.CommandText = "SELECT  Nombre_usuario, Contrasenna, Rol FROM Usuario WHERE Nombre_usuario = @nom and Contrasenna = @cont;";
                sentencia.Parameters.AddWithValue("@nom", nombre);
                sentencia.Parameters.AddWithValue("@cont", contrasenna);

                using (SqlDataReader reader = sentencia.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            toUsuario.Nombre = reader["Nombre_usuario"].ToString();
                            toUsuario.Contrasenna = reader["Contrasenna"].ToString();
                            toUsuario.Rol = reader["Rol"].ToString();
                        }
                    }
                    else {
                        toUsuario.Nombre = "";
                        toUsuario.Contrasenna = "";
                        toUsuario.Rol = "";
                    }


                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conexion.Close();
            return toUsuario;
        }

        

        public void modificarUsuario(string nombre, string contrasenna, string rol)
        {
            establecerConexion();

            try
            {
                sentencia.Transaction = transa;
                sentencia.Connection = conexion;
                sentencia.CommandText = "UPDATE Usuario SET Nombre_usuario = @NombreUsuario, Contrasenna=@contrasenna, Rol=@Rol WHERE Nombre_usuario=@NombreUsuario AND Contrasenna=@Contrasenna;";
                sentencia.Parameters.AddWithValue("@NombreUsuario", nombre);
                sentencia.Parameters.AddWithValue("@Contrasenna", contrasenna);
                sentencia.Parameters.AddWithValue("@Rol", rol);

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
