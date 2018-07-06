using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOAdmin
    {
        public TOAdmin(string nombreAdmin, string contrasennaAdmin, string rol)
        {
            this.nombreAdmin = nombreAdmin;
            this.contrasennaAdmin = contrasennaAdmin;
            this.rol = rol;
        }


        public TOAdmin()
        {
        }
        

        public string nombreAdmin { get; set; }
        public string contrasennaAdmin { get; set; }
        public string rol { get; set; }


    }
}
