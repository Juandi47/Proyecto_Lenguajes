using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorCliente
    {

        

        public int bloquearCliente(string cedula)
        {
            DAOCliente daoCliente = new DAOCliente();
            return daoCliente.bloquearCliente(cedula);
        }


    }
}
