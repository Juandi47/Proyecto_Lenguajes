using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    public class DAOAdmin
    {
        TOAdmin admin = new TOAdmin();
        public TOAdmin consultarAdmin(string nombre, string contrasenna) {
            string query = "select * from Usuario where Nombre_usuario = @nom and Contrasenna = @cont";
            
            return admin;
        }
    }
}
