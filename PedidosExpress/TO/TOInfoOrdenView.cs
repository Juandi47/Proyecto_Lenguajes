using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOInfoOrdenView

    {

        public TOInfoOrdenView() {
            this.detalles = new List<TODetalleOrden>();
        }

        public int Codigo_Orden { get; set; }
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public string Estado_pedido { get; set; }
        public string Hora { get; set; }

        public List<TODetalleOrden> detalles;

        public TOInfoOrdenView(int codigo_Orden, string cedula, string nombre, string apellido1, string apellido2, string Estado_pedido, string tiempo)
        {
            this.Codigo_Orden = codigo_Orden;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Estado_pedido = Estado_pedido;
            this.Hora = tiempo;
            this.detalles = new List<TODetalleOrden>();
        }
    }
}
