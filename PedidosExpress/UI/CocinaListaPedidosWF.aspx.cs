using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using BL;

namespace UI
{
    public partial class CocinaListaPedidosWF : System.Web.UI.Page
    {
        
        ManejadorInfoOrdenView blOrdenes = new ManejadorInfoOrdenView();
        List<InfoOrdenView> ordenes;
        public Thread hilo;
        //private Timer Tiempo { get; set; }
        //public Double Result { get; set; }
        //public DateTime nowTime = DateTime.Now;
        //public DateTime limitTime = new DateTime();

        protected void Page_Load(object sender, EventArgs e)
        {
            ordenes = blOrdenes.ListaOrdenes();
            cargarDivs();
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        //void Tiempo_Tick(object sender, EventArgs e)
        //{
        //    Result++;
        //    //cada tick representa 100 milisegundos
        //}

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
            orderInfo = "Hr: " + ordenes[index].Hora.ToShortTimeString() + ". Cliente: " 
                + ordenes[index].Cedula + " " + ordenes[index].Nombre + " " 
                + ordenes[index].Apellido1 + " " + ordenes[index].Apellido2;

            estado = "Estado: " + ordenes[index].Estado;

            foreach (BLDetalleOrden d in ordenes[index].detallesOrden)
            {
                detallesInfo += d.Cantidad + " orden(es) de " + d.Nombre_plato + "\n";
            }

            switch (position)
            {
             case 1:

                    infoOrden1.Value = orderInfo;
                    estado1.InnerText = estado;
                    detallesO1.Text = detallesInfo;
                    break;

                case 2:
                    infoOrden2.Value = orderInfo;
                    estado2.InnerText = estado;
                    detallesO2.Text = detallesInfo;
                    break;

                case 3:
                    infoOrden3.Value = orderInfo;
                    estado3.InnerText = estado;
                    detallesO3.Text = detallesInfo;
                    break;

                case 4:
                    infoOrden4.Value = orderInfo;
                    estado4.InnerText = estado;
                    detallesO4.Text = detallesInfo;
                    break;

                case 5:
                    infoOrden5.Value = orderInfo;
                    estado5.InnerText = estado;
                    detallesO5.Text = detallesInfo;
                    break;

            default:
                    break;
        }
    }

    }
}