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
        DataTable tabla = new DataTable();

        public List<TOOrdenCliente> ordenesClientes() {
            List<TOOrdenCliente> lista = new List<TOOrdenCliente>();

            string query = "SELECT * FROM cliente C, Orden O WHERE C.Cedula = O.Cedula; ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {
                lista.Add(new TOOrdenCliente((new TOCliente(x["Cedula"].ToString(), x["Nombre"].ToString(),
                        x["Apellido1"].ToString(), x["Apellido2"].ToString(), x["Correo"].ToString(),
                        x["Contrasenna"].ToString(), Int32.Parse(x["Estado_cliente"].ToString()),
                        x["Codigo_postal"].ToString(), x["Nombre_usuario"].ToString())),
                        (new TOInfoOrdenView(x["Cedula"].ToString(), x["Nombre"].ToString(), x["Apellido1"].ToString(),
                        x["Apellido2"].ToString(), Int32.Parse(x["Codigo_Orden"].ToString()),
                        x["Codigo_Plato"].ToString(), x["Nombre_Plato"].ToString(), 
                        Int32.Parse(x["Cantidad"].ToString()), x["Hora"].ToString()))));
            }

            return lista;
        }

    }
}
