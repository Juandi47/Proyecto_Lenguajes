using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOUsuario
    {
       
            private string nombre;
            private string contrasenna;
            private string rol;


        public TOUsuario() { }

        public TOUsuario(string nombre, string contrasenna, string rol)
        {
            this.nombre = nombre;
            this.contrasenna = contrasenna;
            this.rol = rol;
        }

        public String Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public String Contrasenna
            {
                get
                {
                    return contrasenna;
                }
                set
                {
                    contrasenna = value;
                }


            }

            public String Rol
            {
                get
                {
                    return rol;
                }
                set
                {
                    rol = value;
                }
            }


        }
    }

