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

        public void RegistrarCliente(String cedula, String Nombre, String Apellido1, String Apellido2, String correo, String contrasenna, String CodPostal, String NombreUsuario, String Provincia, String Canton, String Distrito) {
            DAOCliente cliente = new DAOCliente();

            cliente.RegistrarCliente(cedula, Nombre, Apellido1, Apellido2, correo, contrasenna, CodPostal, NombreUsuario, Provincia, Canton, Distrito);
        }


    }
}
