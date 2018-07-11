using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLOrdenCliente
    {


        public BLOrdenCliente()
        {
        }

        public BLOrdenCliente(int codigo_Orden, string fecha_Hora, string estado_Pedido, double costo_Total, string cedula, string nombre, string apellido1, string apellido2, string correo, string contrasenna, string estadoCliente, string codigoPostal, string nombreUsuario)
        {
            Codigo_Orden = codigo_Orden;
            Fecha_Hora = fecha_Hora;
            Estado_Pedido = estado_Pedido;
            Costo_Total = costo_Total;
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

        public int Codigo_Orden { get; set; }
        public string Fecha_Hora { get; set; }
        public string Estado_Pedido { get; set; }
        public double Costo_Total { get; set; }


        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string correo { get; set; }
        public string contrasenna { get; set; }
        public string estadoCliente { get; set; }
        public string codigoPostal { get; set; }
        public string nombreUsuario { get; set; }

    }
}
