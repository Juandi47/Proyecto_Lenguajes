using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InfoOrdenView
    {
        public int Codigo_Orden { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Hora { get; set; }

        public List<BLPlato> detallesOrden { get; set; }



        public InfoOrdenView() {
            this.detallesOrden = new List<BLPlato>();
        }

        public InfoOrdenView(string cedula, string nombre, string apellido1, string apellido2, int codigo_Orden, string tiempo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Codigo_Orden = codigo_Orden;
            Hora = tiempo;
            this.detallesOrden = new List<BLPlato>();
        }
    }
}
