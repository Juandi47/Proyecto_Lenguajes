using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLDireccionCliente
    {
        public BLDireccionCliente(string codigoPostal, string provincia, string canton, string distrito)
        {
            this.codigoPostal = codigoPostal;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
        }

        public string codigoPostal { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }


    }
}
