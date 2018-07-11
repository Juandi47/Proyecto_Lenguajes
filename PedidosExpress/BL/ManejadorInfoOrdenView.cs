using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorInfoOrdenView
    {
        List<InfoOrdenView> lista = new List<InfoOrdenView>();

        public List<InfoOrdenView> ListaOrdenes() {

            DAOInfoOrdenView orden = new DAOInfoOrdenView();

            List<TOInfoOrdenView> listaTO = orden.ListaOrdenes();

            foreach (TOInfoOrdenView x in listaTO) {
                lista.Add(new InfoOrdenView(x.Cedula, x.Nombre, x.Apellido1, x.Apellido2, x.Codigo_Orden, x.Hora));
            }
            return lista;
        }


        public List<InfoOrdenView> ListaOrdenesCliente(string cedula)
        {

            DAOInfoOrdenView orden = new DAOInfoOrdenView();

            List<TOInfoOrdenView> listaTO = orden.ListaOrdenesCliente(cedula);

            foreach (TOInfoOrdenView x in listaTO)
            {
                lista.Add(new InfoOrdenView(x.Cedula, x.Nombre, x.Apellido1, x.Apellido2, x.Codigo_Orden, x.Hora));
            }
            return lista;
        }
        
    }
}
