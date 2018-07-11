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

        DAOCliente daoCliente = new DAOCliente();

        public string bloquearCliente(string cedula)
        {
            string bloquear = "";
            if (daoCliente.bloquearCliente(cedula) > 0) {
                bloquear = "Cliente bloqueado";
            }

            return bloquear;
        }


        public string verEstadoCliente(string cedula) {
            string estado;
            TOCliente cliente = daoCliente.buscarCliente(cedula);
            if (cliente.cedula.Equals(""))
            {
                estado = "El cliente con el codigo " + cedula + " no esta registrado en el sistema";
            }
            else {
                if (cliente.estadoCliente > 0)
                {
                    estado = "El cliente se encuentra bloqueado";
                }
                else {
                    estado = "El cliente se encuentra desbloqueado";
                }
            }
            return estado;
        }

        public String RegistrarCliente(String cedula, String Nombre, String Apellido1, String Apellido2, String correo, String contrasenna, String CodPostal, String NombreUsuario, String Provincia, String Canton, String Distrito) {
            return daoCliente.RegistrarCliente(cedula, Nombre, Apellido1, Apellido2, correo, contrasenna, CodPostal, NombreUsuario, Provincia, Canton, Distrito);
        }

        public Boolean loguearCliente(String NombreUsuario, String contrasenna) {
            return daoCliente.logueo(NombreUsuario, contrasenna);

        }


        public string desbloquearCliente(string cedula ) {
            string bloquear = "";
            if (daoCliente.desbloquearCliente(cedula) > 0)
            {
                bloquear = "Cliente bloqueado";
            }

            return bloquear;
        }


    }
}
