using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLAdmin
    {
        public BLAdmin(string nombreAdmin, string contrasennaAdmin, string rol)
        {
            this.nombreAdmin = nombreAdmin;
            this.contrasennaAdmin = contrasennaAdmin;
            this.rol = rol;
        }
        public BLAdmin() { }
        

        public string nombreAdmin { get; set; }
        public string contrasennaAdmin { get; set; }
        public string rol { get; set; }


    }
}
