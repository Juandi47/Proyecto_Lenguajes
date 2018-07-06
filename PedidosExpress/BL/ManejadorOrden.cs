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

        private int ultimoPedidoRegistrado = 0;

        private Boolean mismoPedido = false;

        public int CantidadGridsLlenos { get; set; }
        

        public List<BLOrden> ListaOrdenes() {

            List<BLOrden> lista = new List<BLOrden>();

            DAOOrden orden = new DAOOrden();

            List<TOOrden> listaTO = orden.ListaOrdenes();

            foreach (TOOrden x in listaTO) {
                lista.Add(new BLOrden(x.Cedula, x.Nombre, x.Apellido1, x.Apellido2, x.Codigo_Orden, x.Codigo_Plato, x.Nombre_Plato, x.Cantidad, x.Hora));
            }
            return lista;
        }

        public List<BLOrden> DevolverPedidos()
        {
            
            List<BLOrden> lista = new List<BLOrden>();

            DAOOrden orden = new DAOOrden();

            List<TOOrden> listaTO = orden.ListaOrdenes();

            if (listaTO.Count() > CantidadGridsLlenos && CantidadGridsLlenos <= 5 && ultimoPedidoRegistrado < listaTO.Count())
            {
                if (ultimoPedidoRegistrado == 0 || mismoPedido == true)
                {
                    while ((ultimoPedidoRegistrado == 0) || (listaTO[ultimoPedidoRegistrado].Cedula == listaTO[ultimoPedidoRegistrado - 1].Cedula && listaTO[ultimoPedidoRegistrado].Hora == listaTO[ultimoPedidoRegistrado - 1].Hora))
                    {

                        lista.Add(new BLOrden(listaTO[ultimoPedidoRegistrado].Cedula, listaTO[ultimoPedidoRegistrado].Nombre, listaTO[ultimoPedidoRegistrado].Apellido1, listaTO[ultimoPedidoRegistrado].Apellido2, listaTO[ultimoPedidoRegistrado].Codigo_Orden, listaTO[ultimoPedidoRegistrado].Codigo_Plato, listaTO[ultimoPedidoRegistrado].Nombre_Plato, listaTO[ultimoPedidoRegistrado].Cantidad, listaTO[ultimoPedidoRegistrado].Hora));

                        ultimoPedidoRegistrado++;

                        mismoPedido = true;
                    }
                    mismoPedido = false;

                }
                else {

                    lista.Add(new BLOrden(listaTO[ultimoPedidoRegistrado].Cedula, listaTO[ultimoPedidoRegistrado].Nombre, listaTO[ultimoPedidoRegistrado].Apellido1, listaTO[ultimoPedidoRegistrado].Apellido2, listaTO[ultimoPedidoRegistrado].Codigo_Orden, listaTO[ultimoPedidoRegistrado].Codigo_Plato, listaTO[ultimoPedidoRegistrado].Nombre_Plato, listaTO[ultimoPedidoRegistrado].Cantidad, listaTO[ultimoPedidoRegistrado].Hora));

                    ultimoPedidoRegistrado++;

                    string x = listaTO[ultimoPedidoRegistrado].Cedula;

                    string y = listaTO[ultimoPedidoRegistrado - 1].Cedula;

                    while (ultimoPedidoRegistrado < listaTO.Count && listaTO[ultimoPedidoRegistrado].Cedula == listaTO[ultimoPedidoRegistrado - 1].Cedula && listaTO[ultimoPedidoRegistrado].Hora == listaTO[ultimoPedidoRegistrado - 1].Hora)
                    {
                        
                        lista.Add(new BLOrden(listaTO[ultimoPedidoRegistrado].Cedula, listaTO[ultimoPedidoRegistrado].Nombre, listaTO[ultimoPedidoRegistrado].Apellido1, listaTO[ultimoPedidoRegistrado].Apellido2, listaTO[ultimoPedidoRegistrado].Codigo_Orden, listaTO[ultimoPedidoRegistrado].Codigo_Plato, listaTO[ultimoPedidoRegistrado].Nombre_Plato, listaTO[ultimoPedidoRegistrado].Cantidad, listaTO[ultimoPedidoRegistrado].Hora));

                        ultimoPedidoRegistrado++;

                        mismoPedido = true;
                    }
                    mismoPedido = false;

                }

                              

            }
            else {
                return new List<BLOrden>();
            }                
           
            return lista;
        }


    }
}
