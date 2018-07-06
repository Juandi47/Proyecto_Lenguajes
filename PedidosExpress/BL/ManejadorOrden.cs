using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorOrden
    {
        List<BLOrden> lista = new List<BLOrden>();

        public List<BLOrden> ListaOrdenes() {

            DAOOrden orden = new DAOOrden();

            List<TOOrden> listaTO = orden.ListaOrdenes();

            foreach (TOOrden x in listaTO) {
                lista.Add(new BLOrden(x.Cedula, x.Nombre, x.Apellido1, x.Apellido2, x.Codigo_Orden, x.Codigo_Plato, x.Nombre_Plato, x.Cantidad));
            }
            return lista;
        }
    }
}
