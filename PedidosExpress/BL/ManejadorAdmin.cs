using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorAdmin
    {
        Boolean existe; 

        public Boolean consultarAdmin(string nombre, string contrasenna) {
            DAOAdmin daoAdmin = new DAOAdmin();
            TOAdmin admin = daoAdmin.consultarAdmin(nombre, contrasenna);
            if (admin.nombreAdmin.Equals("") && admin.contrasennaAdmin.Equals(""))
            {
                existe = false;
            }
            else {
                existe = true;
            }

            return existe;
        }

    }
}
