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

        ManejadorOrden bl = new ManejadorOrden();

        protected void Page_Load(object sender, EventArgs e)
        {
            bl.ListaOrdenes
        }
    }
}