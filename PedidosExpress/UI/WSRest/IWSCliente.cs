using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BL;

namespace UI.WSRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWSCliente" in both code and config file together.
    [ServiceContract]
    public interface IWSCliente
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String RegistrarCliente(String cedula, String Nombre, String Apellido1, String Apellido2, String correo, String contrasenna, String CodPostal, String NombreUsuario, String Provincia, String Canton, String Distrito);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Boolean logueo(String NombreUsuario, String contrasenna);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<BLPlato> listaPlatos();
    }    
}
