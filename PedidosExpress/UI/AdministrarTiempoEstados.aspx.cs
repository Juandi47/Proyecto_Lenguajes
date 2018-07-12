using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AdministrarTiempoEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void aceptarBTN_Click(object sender, EventArgs e)
        {
            int tiempo = Int32.Parse(tiempoTXT.Text); 
            ManejadorOrden manejador = new ManejadorOrden();
            manejador.modificarEstado(tiempo);
            
        }
    }
}