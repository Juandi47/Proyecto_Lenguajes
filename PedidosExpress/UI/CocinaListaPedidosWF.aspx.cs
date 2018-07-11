using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class CocinaListaPedidosWF : System.Web.UI.Page
    {

        ManejadorOrden blOrdenes = new ManejadorOrden();
        List<BLOrden> ordenes;
        protected void Page_Load(object sender, EventArgs e)
        {
             ordenes = blOrdenes.ListaOrdenes();
            infoO1.Text = ordenes[0].Codigo_Orden + "-" + ordenes[0].Hora.ToLocalTime().ToShortTimeString() 
                + ".     Cliente: " + ordenes[0].Nombre + " " + ordenes[0].Apellido1 + " " + ordenes[0].Apellido2;
            estadoO1.Text = " " + ordenes[0].Estado;

            string detalles = "";
            for (int i = 0; i < ordenes[0].detallesOrden.Count; i++)
            {
                detalles += i+1 + ") " + ordenes[0].detallesOrden[i].Codigo_plato + "-"
                    + ordenes[0].detallesOrden[i].Nombre_plato + ". Cantidad    " + ordenes[0].detallesOrden[i].Cantidad + ".\n";
            }
            detallesO1.Text = detalles;


        }

        protected void entregarBTN1_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarDivs() {
           
            switch (ordenes.Count)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:
                    break;

                case 5:

                    break;

                default:
                    break;
            }
        }

        public void cargarGridAtN(int position) {

            String orderInfo = "";
            String detallesInfo = "";
            switch (position)
            {
             case 1:
                   
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:
                    break;

                case 5:

                    break;

            default:
                    break;
        }
    }
        
    }
}