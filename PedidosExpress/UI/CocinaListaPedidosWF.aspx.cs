using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Drawing;
using BL;
using System.Reflection;

namespace UI
{
    public partial class CocinaListaPedidosWF : System.Web.UI.Page
    {
        
        ManejadorInfoOrdenView blOrdenes = new ManejadorInfoOrdenView();
        List<InfoOrdenView> ordenes;
        private DateTime tiempoLimitOrden1;
        private DateTime tiempoLimitOrden2;
        private DateTime tiempoLimitOrden3;
        private DateTime tiempoLimitOrden4;
        private DateTime tiempoLimitOrden5;
        private double limiteMin = 5;

        protected void Page_Load(object sender, EventArgs e)
        {
            ordenes = blOrdenes.ListaOrdenes();
            cargarDivs();
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString().ToString();
            cambiarEstadoAuto(0, DateTime.Now);
            //cambiarEstadoAuto(1, DateTime.Now);
            //cambiarEstadoAuto(2, DateTime.Now);
            //cambiarEstadoAuto(3, DateTime.Now);
            //cambiarEstadoAuto(4, DateTime.Now);
        }


        protected void entregarBTN1_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarDivs() {

            switch (ordenes.Count)
            {
                case 1:
                    cargarGridAtN(1);
                    break;

                case 2:

                    cargarGridAtN(1);
                    cargarGridAtN(2);

                    break;

                case 3:
                    cargarGridAtN(1);
                    cargarGridAtN(2);
                    cargarGridAtN(3);
                    break;

                case 4:
                    cargarGridAtN(1);
                    cargarGridAtN(2);
                    cargarGridAtN(3);
                    cargarGridAtN(4);
                    break;

                case 5:
                    cargarGridAtN(1);
                    cargarGridAtN(2);
                    cargarGridAtN(3);
                    cargarGridAtN(4);
                    cargarGridAtN(5);
                    break;

                default:
                    break;
            }
        }

        public void cargarGridAtN(int position) {

            String orderInfo = "";
            String estado = "";
            String detallesInfo = "";
            int index = position - 1;
            Color c = new Color();

            orderInfo = "Hr: " + ordenes[index].Hora.ToShortTimeString() + ". Cliente: " 
                + ordenes[index].Cedula + " " + ordenes[index].Nombre + " " 
                + ordenes[index].Apellido1 + " " + ordenes[index].Apellido2;

            estado = "Estado: " + ordenes[index].Estado;
            switch (ordenes[index].Estado) {
                case "A Tiempo":
                    c = Color.LightGreen;
                    
                    break;
                case "Sobre Tiempo":
                    c = Color.LightYellow;
                    break;
                case "Demorado":
                    c = Color.Yellow;
                    break;
                case "Anulado":
                    c = Color.Red;
                    break;
                case "Entregado":
                    c = Color.LightBlue;
                    break;
                default:
                    c = Color.White;
                    break;

            }

            foreach (BLDetalleOrden d in ordenes[index].detallesOrden)
            {
                detallesInfo += d.Cantidad + " orden(es) de " + d.Nombre_plato + "\n";
            }

            switch (position)
            {
             case 1:
                    tiempoLimitOrden1 = ordenes[index].Hora.AddMinutes(limiteMin) ;
                    infoOrden1.Value = orderInfo;
                    e1.Text = estado;
                    e1.BackColor = c;
                    detallesO1.Text = detallesInfo;
                    break;

                case 2:
                    tiempoLimitOrden2 = ordenes[index].Hora.AddMinutes(limiteMin);
                    infoOrden2.Value = orderInfo;
                    e2.Text = estado;
                    e2.BackColor = c;
                    detallesO2.Text = detallesInfo;
                    break;

                case 3:
                    tiempoLimitOrden3 = ordenes[index].Hora.AddMinutes(limiteMin);
                    infoOrden3.Value = orderInfo;
                    e3.Text = estado;
                    e3.BackColor = c;
                    detallesO3.Text = detallesInfo;
                    break;

                case 4:
                    tiempoLimitOrden4 = ordenes[index].Hora.AddMinutes(limiteMin);
                    infoOrden4.Value = orderInfo;
                    e4.Text = estado;
                    e4.BackColor = c;
                    detallesO4.Text = detallesInfo;
                    break;

                case 5:
                    tiempoLimitOrden5 = ordenes[index].Hora.AddMinutes(limiteMin);
                    infoOrden5.Value = orderInfo;
                    e5.Text = estado;
                    e5.BackColor = c;
                    detallesO5.Text = detallesInfo;
                    break;

            default:
                    break;
        }
    }


        public void cambiarEstadoAuto(int index, DateTime tiempo) {
            String nuevoEstado = "";
            switch (index) {

                case 0:
                    if (  (tiempoLimitOrden1.Minute - tiempo.Minute) < 0) {
                        nuevoEstado = siguienteEstado(ordenes[0].Estado);
                        blOrdenes.actualizarEstado(ordenes[0].Codigo_Orden, nuevoEstado);
                        actualizarLabelEstado(0, nuevoEstado);
                        tiempoLimitOrden1.AddMinutes(limiteMin);
                        Response.Redirect(Request.RawUrl);
                    }
                    break;
                case 1:
                    if (tiempo >= tiempoLimitOrden2)
                    {
                        nuevoEstado = siguienteEstado(ordenes[1].Estado);
                        blOrdenes.actualizarEstado(ordenes[1].Codigo_Orden, nuevoEstado);
                        actualizarLabelEstado(1, nuevoEstado);
                    }
                    break;
                case 2:
                    if (tiempo >= tiempoLimitOrden3)
                    {
                        nuevoEstado = siguienteEstado(ordenes[2].Estado);
                        blOrdenes.actualizarEstado(ordenes[2].Codigo_Orden, nuevoEstado);
                        actualizarLabelEstado(2, nuevoEstado);
                    }
                    break;
                case 3:
                    if (tiempo >= tiempoLimitOrden4)
                    {
                        nuevoEstado = siguienteEstado(ordenes[3].Estado);
                        blOrdenes.actualizarEstado(ordenes[3].Codigo_Orden, nuevoEstado);
                        actualizarLabelEstado(3, nuevoEstado);
                    }
                    break;
                case 4:
                    if (tiempo >= tiempoLimitOrden5)
                    {

                        nuevoEstado = siguienteEstado(ordenes[4].Estado);
                        blOrdenes.actualizarEstado(ordenes[4].Codigo_Orden, nuevoEstado);
                        actualizarLabelEstado(4, nuevoEstado);
                    }
                    break;
                default:

                    break;

            }
        }

        private void actualizarLabelEstado(int index, string nuevoEstado) {

            Color c = new Color();

            switch (nuevoEstado) {
                case "A Tiempo":
                    c = Color.LightGreen;

                    break;
                case "Sobre Tiempo":
                    c = Color.LightYellow;
                    break;
                case "Demorado":
                    c = Color.Yellow;
                    break;
                case "Anulado":
                    c = Color.Red;
                    break;
                case "Entregado":
                    c = Color.LightBlue;
                    break;
                default:
                    c = Color.White;
                    break;
            }

            switch (index) {
                case 0:
                    e1.Text = nuevoEstado;
                    e1.BackColor = c;
                    break;
                case 1:
                    e2.Text = nuevoEstado;
                    e2.BackColor = c;
                    break;
                case 2:
                    e3.Text = nuevoEstado;
                    e3.BackColor = c;
                    break;
                case 3:
                    e4.Text = nuevoEstado;
                    e4.BackColor = c;
                    break;
                case 4:
                    e5.Text = nuevoEstado;
                    e5.BackColor = c;
                    break;
                default:

                    break;
            }

        }

        private string siguienteEstado(string estadoActual) {
            String c = "Demorado";
            switch (estadoActual)
            {
                case "A Tiempo":
                    c = "Sobre Tiempo";
                    break;
                case "Sobre Tiempo":
                    c = "Demorado";
                    break;
                case "Demorado":
                    c = "Anulado";
                    return c;
                   
                default:
                   
                    break;
            }
            return c;
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            blOrdenes.entregarOrden(ordenes[0].Codigo_Orden);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            blOrdenes.entregarOrden(ordenes[1].Codigo_Orden);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            blOrdenes.entregarOrden(ordenes[2].Codigo_Orden);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            blOrdenes.entregarOrden(ordenes[3].Codigo_Orden);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            blOrdenes.entregarOrden(ordenes[4].Codigo_Orden);
            Response.Redirect(Request.RawUrl);
        }
    }
}