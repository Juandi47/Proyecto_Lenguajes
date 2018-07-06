using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOUsuario
    {
       
            private string identificacion;
            private string nombre;
            private string contrasenna;
            private string rol;

            public TOUsuario(string identificacion, string nombre, string contrasenna, string rol)
            {
                this.identificacion = identificacion;
                this.nombre = nombre;
                this.contrasenna = contrasenna;
                this.rol = rol;
            }

            public String Identificacion
            {
                get
                {
                    return identificacion;
                }
                set
                {
                    identificacion = value;
                }


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
}
