using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLCliente
    {
        public BLCliente(string cedula, string nombre, string apellido1, string apellido2, string correo, string contrasenna, int estadoCliente, string codigoPostal, string nombreUsuario)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.correo = correo;
            this.contrasenna = contrasenna;
            this.estadoCliente = estadoCliente;
            this.codigoPostal = codigoPostal;
            this.nombreUsuario = nombreUsuario;
        }

        public BLCliente()
        {

        }


        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string correo { get; set; }
        public string contrasenna { get; set; }
        public int estadoCliente { get; set; }
        public string codigoPostal { get; set; }
        public string nombreUsuario { get; set; }

    }
}
