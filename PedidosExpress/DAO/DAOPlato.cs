using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOPlato
    {
        TOPlato plato = new TOPlato();
       // SqlConnection conexion = new SqlConnection(DAO.Properties.Settings);

        public TOPlato consultarPlato(string codigo) {
            string query = "select *  from Plato where Codigo_Plato = @cod";
           // SqlCommand comand = new SqlCommand(query, );
            //comand.Parameters.AddWithValue("@cod", codigo);

            
            return plato;
        }
    }
}
