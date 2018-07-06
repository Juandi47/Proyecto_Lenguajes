using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class LoguearUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            ManejadorAdmin manejador = new ManejadorAdmin();
            if (manejador.consultarAdmin(txtNombreAdmin.Text, txtPassword.Text))
            {
                Response.Redirect("PrincipalAdmin.aspx");
            }
            else {
                Response.Redirect("LoguearUsuarios.aspx");
            }

        }
    }
}