using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class AdministrarPedidos : System.Web.UI.Page
    {


        ManejadorOrdenCliente blOrdenCliente = new ManejadorOrdenCliente();

        List<string> coleccionFechas = new List<string>();
        

        

        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack) {
                ViewState["ListaFechas"] = coleccionFechas;
            }

            coleccionFechas = (List<string>)ViewState["ListaFechas"];
            

            List<BLOrdenCliente> lista = new List<BLOrdenCliente>();
            lista = blOrdenCliente.listaOrdenCliente();
            String orden = lista[0].nombre;
            if (orden.Equals(""))
            {
                String mensaje = "No hay datos";
            }
            else {

                grdClientes.DataSource = lista;
                grdClientes.DataBind();
            }
            
        }

        protected void btnVerTodosClientes_Click(object sender, EventArgs e)
        {
            
            List<BLOrdenCliente> lista = new List<BLOrdenCliente>();
            lista = blOrdenCliente.listaOrdenCliente();
            String orden = lista[0].nombre;
            if (orden.Equals(""))
            {
                String mensaje = "No hay datos";
            }
            else {

                grdClientes.DataSource = lista;
                grdClientes.DataBind();
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (checkHabilitarCliente.Checked) {
                List<BLOrden> lista = new List<BLOrden>();
                lista = blOrdenCliente.buscarPedidosCliente(txtBuscarPorCliente.Text);
                grdClientes.DataSource = lista;
                grdClientes.DataBind();
            }
            else {
                string mensaje = " Debe habilitar el filtro de busqueda";
            }
        }

        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            string cambio;
            if (radioEstadoAtiempo.Checked)
            {
                cambio = blOrdenCliente.cambiarEstadoOrden(txtCambiarEstado.Text, "A Tiempo");
            }
            else {
                if (radioEstadoSobreTiempo.Checked)
                {
                    cambio = blOrdenCliente.cambiarEstadoOrden(txtCambiarEstado.Text, "Sobre Tiempo");
                }
                else {
                    if (radioEstadoDemorado.Checked)
                    {
                        cambio = blOrdenCliente.cambiarEstadoOrden(txtCambiarEstado.Text, "Demorado");
                    }
                    else {
                        if (radioEstadoAnulado.Checked)
                        {
                            cambio = blOrdenCliente.cambiarEstadoOrden(txtCambiarEstado.Text, "Anulado");
                        }
                        else {
                            if (radioEstadoEntregado.Checked)
                            {

                                cambio = blOrdenCliente.cambiarEstadoOrden(txtCambiarEstado.Text, "Entregado");
                            }
                        }
                    }
                }
            }

            List<BLOrdenCliente> lista = new List<BLOrdenCliente>();
            lista = blOrdenCliente.listaOrdenCliente();
            

                grdClientes.DataSource = lista;
                grdClientes.DataBind();
        
        }

        protected void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            List<string> fechas = new List<string>();
            string fecha1;
            string fecha2;
            if (checkFiltrarPorFecha.Checked)
            {
                if (coleccionFechas.Count > 1)
                {
                    string actual = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
                    fecha1 = coleccionFechas[coleccionFechas.Count - 2];
                    fecha2 = coleccionFechas[coleccionFechas.Count - 1];
                    //!(DateTime.Compare(Convert.ToDateTime(fechas[0]), DateTime.Now) > 1)
                    //if ((fecha1.CompareTo(actual) > 0) && (fecha2.CompareTo(actual) > 0))
                    {
                        if (txtBuscarPorCliente.Text.Equals(""))
                        {
                            List<BLOrden> lista = new List<BLOrden>();
                            fechas.Add(fecha1);
                            fechas.Add(fecha2);
                            fechas.Sort();

                            lista = blOrdenCliente.buscarPedidosPorFecha(fechas);
                            grdClientes.DataSource = lista;
                            grdClientes.DataBind();
                        }
                        else {
                            List<BLOrden> lista = new List<BLOrden>();
                            fechas.Add(fecha1);
                            fechas.Add(fecha2);
                            fechas.Sort();

                            lista = blOrdenCliente.buscarPedidosClientePorFecha(fechas, txtBuscarPorCliente.Text);
                            grdClientes.DataSource = lista;
                            grdClientes.DataBind();
                        }
                    }
                    //else {
                    //    string texto = "Las fechas elegidas deben ser anteriores a la fecha actual";
                    //}
                    
                }
                else {
                    string error = "Debe seleccionar al menos dos fechas";
                }

            }
            else {
                string mensaje = "Debe activar el filtro de busqueda";
            }
        }

        protected void calendarioFiltro_SelectionChanged(object sender, EventArgs e)
        {
            string fecha = calendarioFiltro.SelectedDate.Year.ToString();
            string mes = calendarioFiltro.SelectedDate.Month.ToString();
            if (Int32.Parse(mes) < 10)
            {
                fecha += "/0" + mes;
            }
            else {
                fecha += "/" + mes;
            }

            string dia = calendarioFiltro.SelectedDate.Day.ToString();
            if (Int32.Parse(dia) < 10)
            {
                fecha += "/0" + dia;
            }
            else {
                fecha += "/" +  dia;
            }

            coleccionFechas.Add(fecha);
            
        }

        protected void btnBuscarPorEstados_Click(object sender, EventArgs e)
        {
            List<BLOrden> lista = new List<BLOrden>();


            if (radioAtiempo.Checked)
            {

                if (txtBuscarPorCliente.Text.Equals(""))
                {//para todos 
                   

                    lista = blOrdenCliente.buscarPedidosEstado("A Tiempo");
                    grdClientes.DataSource = lista;
                    grdClientes.DataBind();

                }
                else {
                    //uno solo
                    lista = blOrdenCliente.buscarPedidosClienteEstado("A Tiempo", txtBuscarPorCliente.Text);
                    grdClientes.DataSource = lista;
                    grdClientes.DataBind();
                }


            }
            else {
                if (radioSobreTiempo.Checked)
                {
                    if (txtBuscarPorCliente.Text.Equals(""))
                    {//para todos 

                        lista = blOrdenCliente.buscarPedidosEstado("Sobre Tiempo");
                        grdClientes.DataSource = lista;
                        grdClientes.DataBind();


                    }
                    else {
                        //para solo un cliente 
                        lista = blOrdenCliente.buscarPedidosClienteEstado("Sobre Tiempo", txtBuscarPorCliente.Text);
                        grdClientes.DataSource = lista;
                        grdClientes.DataBind();
                    }
                }
                else {
                    if (radioDemorado.Checked)
                    {
                        if (txtBuscarPorCliente.Text.Equals(""))
                        {//para todos 

                            lista = blOrdenCliente.buscarPedidosEstado("Demorado");
                            grdClientes.DataSource = lista;
                            grdClientes.DataBind();


                        }
                        else {
                            //para solo un cliente 

                            lista = blOrdenCliente.buscarPedidosClienteEstado("Demorado", txtBuscarPorCliente.Text);
                            grdClientes.DataSource = lista;
                            grdClientes.DataBind();
                        }
                    }
                    else {
                        if (radioAnulado.Checked)
                        {
                            if (txtBuscarPorCliente.Text.Equals(""))
                            {//para todos 

                                lista = blOrdenCliente.buscarPedidosEstado("Anulado");
                                grdClientes.DataSource = lista;
                                grdClientes.DataBind();


                            }
                            else {
                                //para solo un cliente 
                                lista = blOrdenCliente.buscarPedidosClienteEstado("Anulado", txtBuscarPorCliente.Text);
                                grdClientes.DataSource = lista;
                                grdClientes.DataBind();
                            }
                        }
                        else {
                            if (txtBuscarPorCliente.Text.Equals(""))
                            {//para todos 

                                lista = blOrdenCliente.buscarPedidosEstado("Entregado");
                                grdClientes.DataSource = lista;
                                grdClientes.DataBind();


                            }
                            else {
                                //para solo un cliente 
                                lista = blOrdenCliente.buscarPedidosClienteEstado("Entregado", txtBuscarPorCliente.Text);
                                grdClientes.DataSource = lista;
                                grdClientes.DataBind();
                            }
                        }
                    }
                }


            }

        }
    }
}