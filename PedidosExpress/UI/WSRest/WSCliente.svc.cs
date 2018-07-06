using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;

namespace UI.WSRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSCliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSCliente.svc or WSCliente.svc.cs at the Solution Explorer and start debugging.
    public class WSCliente : IWSCliente
    {
        public void RegistrarCliente(string cedula, string Nombre, string Apellido1, string Apellido2, string correo, string contrasenna, string CodPostal, string NombreUsuario, string Provincia, string Canton, string Distrito)
        {
            new ManejadorCliente().RegistrarCliente(cedula, Nombre, Apellido1, Apellido2, correo, contrasenna, CodPostal, NombreUsuario, Provincia, Canton, Distrito);
        }
    }
}
