using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLDetalleOrden
    {

        public int Codigo_orden { get; set; }
        public string Codigo_plato { get; set; }
        public string Nombre_plato { get; set; }
        public int Cantidad { get; set; }
        public double Precio_linea { get; set; }

        public BLDetalleOrden(){ }

        public BLDetalleOrden(int codeO, string codeP, string nombreP, int cantidad, double precio) {
            this.Codigo_orden = codeO;
            this.Codigo_plato = codeP;
            this.Nombre_plato = nombreP;
            this.Cantidad = cantidad;
            this.Precio_linea = precio;
        }
    }
}
