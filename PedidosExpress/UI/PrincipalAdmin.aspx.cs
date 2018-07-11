using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class PrincipalAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdministrarPlatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministracionPlatos.aspx");
        }

        protected void btnAdministrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministracionUsuarios.aspx");
        }

        protected void btnBloquear_Click(object sender, EventArgs e)
        {
            Response.Redirect("BloquearClientes.aspx");
        }

        protected void btnAdministrarPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}