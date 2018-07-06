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
    public class DAOPlato
    {
        TOPlato plato = new TOPlato();
        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.ConnectionString);
        string query;

        public TOPlato consultarPlato(string codigo) {
            query = "select *  from Plato where Codigo_Plato = @cod";

            if (conexion.State != ConnectionState.Open) {
                conexion.Open();
            }
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@cod", codigo);
            SqlDataReader reader = comand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) {
                    plato.codigoPlato = reader["Codigo_Plato"].ToString();
                    plato.nombrePlato = reader["Nombre_plato"].ToString();
                    plato.descripcionPlato = reader["Descripcion"].ToString();
                    plato.precio = Convert.ToDouble(reader["Precio"]);
                    plato.estadoPlato = reader["Estado_plato"].ToString();
                    plato.imagen = reader["Imagen"].ToString();
                }

            }
            else {
                plato.codigoPlato = "";
                plato.nombrePlato = "";
                plato.descripcionPlato = "";
                plato.precio = 0;
                plato.estadoPlato = "";
                plato.imagen = "";
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return plato;
        }

        public int modificarPlato(string codigo, string nombre, string descripcion, string precio, string estado, string imagen) {
            int modificar;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            query = "UPDATE Plato  SET Nombre_plato = @nom, Descripcion = @des, Precio = @pre, Estado_plato = @est, Imagen = @img WHERE Codigo_Plato = @cod;";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@cod", codigo);
            comand.Parameters.AddWithValue("@nom", nombre);
            comand.Parameters.AddWithValue("@des", descripcion);
            comand.Parameters.AddWithValue("@pre", precio);
            comand.Parameters.AddWithValue("@est", estado);
            comand.Parameters.AddWithValue("@img", imagen);

            int reader = comand.ExecuteNonQuery();
            modificar = reader;

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return modificar;
        }


        public int agregarPlato(string codigo, string nombre, string descripcion, string precio, string estado, string imagen) {
            int rowAfec;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            query = "insert into Plato values(@cod, @nom, @des, @pre, @est, @img)";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@cod", codigo);
            comand.Parameters.AddWithValue("@nom", nombre);
            comand.Parameters.AddWithValue("@des", descripcion);
            comand.Parameters.AddWithValue("@pre", precio);
            comand.Parameters.AddWithValue("@est", estado);
            comand.Parameters.AddWithValue("@img", imagen);

            rowAfec = comand.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return rowAfec;
        }

        public int eliminarPlato(string codigo) {
            int eliminar;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            query = "delete Plato where Codigo_Plato = @cod";
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@cod", codigo);

            eliminar = comand.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return eliminar;
        }


    }
}
