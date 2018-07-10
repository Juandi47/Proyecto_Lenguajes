using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOOrden
    {
        public TOOrden(int codigo_Orden, string fecha_Hora, string cedula, string estado_Pedido, string costo_Total)
        {
            Codigo_Orden = codigo_Orden;
            Fecha_Hora = fecha_Hora;
            Cedula = cedula;
            Estado_Pedido = estado_Pedido;
            Costo_Total = costo_Total;
        }

        public TOOrden()
    {
        }

        public int Codigo_Orden { get; set; }
        public string Fecha_Hora { get; set; }
        public string Cedula { get; set; }
        public string Estado_Pedido { get; set; }
        public string Costo_Total { get; set; }
    }
}
