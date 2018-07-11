using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorOrdenCliente
    {

        DAOOrdenCliente daoOrdenCliente = new DAOOrdenCliente();

        public List<BLOrdenCliente> listaOrdenCliente()
        {
            List<BLOrdenCliente> lista = new List<BLOrdenCliente>();
            
            List<TOOrdenCliente> listaTo = daoOrdenCliente.ordenesClientes();

            foreach (TOOrdenCliente item in listaTo)
            {
                lista.Add(new BLOrdenCliente( item.Codigo_Orden, item.Fecha_Hora,
                    item.Estado_Pedido, item.Costo_Total, item.Cedula,
                    item.nombre, item.apellido1, item.apellido2,
                    item.correo, item.contrasenna, item.estadoCliente,
                    item.codigoPostal, item.nombreUsuario));
            }


            return lista;
        }
        public List<BLOrden> buscarPedidosCliente(string cedula) {
            List<BLOrden> listaPedidos = new List<BLOrden>();
            List<TOOrden> listaTO = new List<TOOrden>();
            listaTO = daoOrdenCliente.buscarPedidosCliente(cedula);


            foreach (TOOrden item in listaTO)
            {
                listaPedidos.Add(new BLOrden(item.Codigo_Orden, item.Fecha_Hora, item.Cedula,
                    item.Estado_Pedido, item.Costo_Total));
            }

            return listaPedidos;

        }

        public List<BLOrden> buscarPedidosPorFecha(List<string> fechas) {
            List<BLOrden> listaPedidos = new List<BLOrden>();

            List<TOOrden> lista =  daoOrdenCliente.buscarPedidosPorFecha(fechas);

            foreach (TOOrden item in lista)
            {
                listaPedidos.Add(new BLOrden(item.Codigo_Orden, item.Fecha_Hora, item.Cedula,
                    item.Estado_Pedido, item.Costo_Total));
            }

            return listaPedidos;

        }


        public List<BLOrden> buscarPedidosClientePorFecha(List<string> fechas, string cedula)
        {
            List<BLOrden> listaPedidos = new List<BLOrden>();

            List<TOOrden> lista = daoOrdenCliente.buscarPedidosClientePorFecha(fechas, cedula);

            foreach (TOOrden item in lista)
            {
                listaPedidos.Add(new BLOrden(item.Codigo_Orden, item.Fecha_Hora, item.Cedula,
                    item.Estado_Pedido, item.Costo_Total));
            }

            return listaPedidos;

        }

        
        public List<BLOrden> buscarPedidosEstado(string estado)
        {
            List<BLOrden> listaPedidos = new List<BLOrden>();

            List<TOOrden> lista = daoOrdenCliente.buscarPedidosEstado(estado);

            foreach (TOOrden item in lista)
            {
                listaPedidos.Add(new BLOrden(item.Codigo_Orden, item.Fecha_Hora, item.Cedula,
                    item.Estado_Pedido, item.Costo_Total));
            }

            return listaPedidos;

        }


        public List<BLOrden> buscarPedidosClienteEstado(string estado, string cedula)
        {
            List<BLOrden> listaPedidos = new List<BLOrden>();

            List<TOOrden> lista = daoOrdenCliente.buscarPedidosClienteEstado(estado, cedula);

            foreach (TOOrden item in lista)
            {
                listaPedidos.Add(new BLOrden(item.Codigo_Orden, item.Fecha_Hora, item.Cedula,
                    item.Estado_Pedido, item.Costo_Total));
            }

            return listaPedidos;

        }

        public string cambiarEstadoOrden(string codigo, string estado)
        {
            int filasAfectadas;
            string mensaje;

            filasAfectadas = daoOrdenCliente.cambiarEstadoOrden(codigo, estado);

            if (filasAfectadas > 0)
            {
                mensaje = "Estado cambiado";
            }
            else {
                mensaje = "Codigo no encontrado";
            }

            return mensaje;

        }
        


    }
}
