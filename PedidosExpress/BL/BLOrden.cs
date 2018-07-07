using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class BLOrden
    {
        public int Codigo_Orden { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Estado { get; set; }
        public DateTime Hora { get; set; }

        public List<BLDetalleOrden> detallesOrden { get; set; }



        public BLOrden() {
            this.detallesOrden = new List<BLDetalleOrden>();
        }

        public BLOrden(int codigo_Orden, string cedula, string nombre, string apellido1, string apellido2, string estado, DateTime tiempo)
        {
            this.Codigo_Orden = codigo_Orden;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Estado = estado;
            this.Hora = tiempo;
            this.detallesOrden = new List<BLDetalleOrden>();
        }

        public void cloneOrders(List<TODetalleOrden> toList) {
            foreach (var x in toList)
            {
                BLDetalleOrden dt = new BLDetalleOrden();
                dt.Codigo_orden = x.Codigo_orden;
                dt.Codigo_plato = x.Codigo_plato;
                dt.Nombre_plato = x.Nombre_plato;
                dt.Cantidad = x.Cantidad;
                dt.Precio_linea = x.Precio_linea;
                this.detallesOrden.Add(dt);
            }
        }


    }
}
