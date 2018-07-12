using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FacebookID_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://facebook.com/");
        }

        protected void TwitterID_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://twitter.com/?lang=en");
        }

        protected void ContactoID_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.whatsapp.com/");
        }

        protected void HomeButton_Click(object sender, ImageClickEventArgs e)
        {

            string sRet = System.IO.Path.GetFileName(Request.Url.AbsolutePath);
            if (sRet.Equals("AdministracionPlatos.aspx") || sRet.Equals("AdministracionUsuarios.aspx") || sRet.Equals("AdministrarTiempoEstados.aspx")
                || sRet.Equals("BloquearClientes.aspx") || sRet.Equals("AdministrarPedidos.aspx"))
            {
                Response.Redirect("PrincipalAdmin.aspx");
            }

        


     

        }

        protected void signout_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LoguearUsuarios.aspx");  
        }
    }
}