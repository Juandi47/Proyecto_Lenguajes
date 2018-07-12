using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

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

        public List<BLDetalleOrden> detallesOrden { get; set; }



        public InfoOrdenView() {
            this.detallesOrden = new List<BLDetalleOrden>();
        }

        public InfoOrdenView(string cedula, string nombre, string apellido1, string apellido2, int codigo_Orden, string tiempo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Codigo_Orden = codigo_Orden;
            Hora = tiempo;
            this.detallesOrden = new List<BLDetalleOrden>();
        }

        internal void clonarDetalles(List<TODetalleOrden> detalles)
        {
            foreach (TODetalleOrden d in detalles)
            {
                BLDetalleOrden blDetalle = new BLDetalleOrden(d.Codigo_orden, d.Codigo_plato, d.Nombre_plato, d.Cantidad, d.Precio_linea);
                this.detallesOrden.Add(blDetalle);
            }
        }
    }
}
