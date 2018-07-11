using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLUsuario
    {


        public BLUsuario()
        {
        }

        public BLUsuario(string nombreUsuario, string contrasennaUsuario, string rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasennaUsuario = contrasennaUsuario;
            this.rol = rol;
        }

        public string nombreUsuario { get; set; }
        public string contrasennaUsuario{ get; set; }
        public string rol { get; set; }
        

    }
}
