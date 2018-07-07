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

            DAOOrden DAOorden = new DAOOrden();

            List<TOOrden> listaTO = DAOorden.ListaOrdenes();

            foreach (TOOrden x in listaTO) {
                BLOrden o = new BLOrden(x.Codigo_Orden, x.Cedula, x.Nombre, x.Apellido1, x.Apellido2, x.Estado, x.Hora);
                lista.Add(o);
                o.cloneOrders(x.detallesOrden);
            }
            return lista;
        }

    }
}
