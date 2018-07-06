using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOOrden

    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public int Codigo_Orden { get; set; }

        public string Codigo_Plato { get; set; }

        public string Nombre_Plato { get; set; }

        public int Cantidad { get; set; }

        public string Hora { get; set; }


        public TOOrden(string cedula, string nombre, string apellido1, string apellido2, int codigo_Orden, string codigo_Plato, string nombre_Plato, int cantidad, string tiempo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Codigo_Orden = codigo_Orden;
            Codigo_Plato = codigo_Plato;
            Nombre_Plato = nombre_Plato;
            Cantidad = cantidad;
            Hora = tiempo;
        }
    }
}
