using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOOrden

    {
        public int Codigo_Orden { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Estado { get; set; }
        public DateTime Hora { get; set; }
        public List<TODetalleOrden> detallesOrden { get; set; }

        public TOOrden()
        {
            this.detallesOrden = new List<TODetalleOrden>();
        }

        public TOOrden(int codigo_Orden, string cedula, string nombre, string apellido1, string apellido2, string estado, DateTime tiempo)
        {
            this.Codigo_Orden = codigo_Orden;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Estado = estado;
            this.Hora = tiempo;
            this.detallesOrden = new List<TODetalleOrden>();
        }
    }
}
