using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOPlato
    {
        public TOPlato(string codigoPlato, string nombrePlato, string descripcionPlato, double precio, string estadoPlato, string imagen)
        {
            this.codigoPlato = codigoPlato;
            this.nombrePlato = nombrePlato;
            this.descripcionPlato = descripcionPlato;
            this.precio = precio;
            this.estadoPlato = estadoPlato;
            this.imagen = imagen;
        }

        public TOPlato()
        {
        }


        public string codigoPlato { get; set; }
        public string nombrePlato { get; set; }
        public string descripcionPlato { get; set; }
        public double precio { get; set; }
        public string estadoPlato { get; set; }
        public string imagen { get; set; }

    }
}
