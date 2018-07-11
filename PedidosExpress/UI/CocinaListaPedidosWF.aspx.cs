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
            // ordenes = blOrdenes.ListaOrdenes();
          
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