using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class ManejadorOrden
    {
        public DAOOrden daoOrden = new DAOOrden();


        public void agregarOrden(int codigo_Orden, DateTime fecha_Hora, string cedula, string estado_Pedido, double costo_Total)
        {

            if (daoOrden.insertarOrden(codigo_Orden, fecha_Hora, cedula, estado_Pedido, costo_Total))
            {


                //new TiemposOrdenes().administrarTiempoOrden(codigo_Orden); 
                //controladorTiempo. 
            }

        }

        public void modificarEstado(int lapso)
        {
            daoOrden.modificarLapso(lapso);
        }





        public void eliminarOrden(int codigo_Orden)
        {
            daoOrden.eliminarOrden(codigo_Orden);
        }

        public void modificarOrden(int codigo_Orden, DateTime fecha_Hora, string cedula, string estado_Pedido, double costo_Total)
        {
            daoOrden.modificarOrden(codigo_Orden, fecha_Hora, cedula, estado_Pedido, costo_Total);
        }


        public BLOrden consultarOrden(int codigo_Orden)
        {
            TOOrden toOrden = daoOrden.buscarOrden(codigo_Orden);
            BLOrden ordenBl = new BLOrden(toOrden.Codigo_Orden, toOrden.Fecha_Hora, toOrden.Cedula, toOrden.Estado_Pedido, toOrden.Costo_Total);

            return ordenBl;
        }

    }
}
