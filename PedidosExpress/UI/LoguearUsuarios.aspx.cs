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

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            ManejadorUsuario manejador = new ManejadorUsuario();
            BLUsuario usuariobl = manejador.consultarUsuario(txtNombreAdmin.Text, txtPassword.Text);
            if (usuariobl.nombreUsuario.Equals("") && usuariobl.contrasennaUsuario.Equals(""))
            {
                Response.Redirect("LoguearUsuarios.aspx");
            }
            else {
                if (usuariobl.rol.Equals("Administrador"))
                {
                    Response.Redirect("PrincipalAdmin.aspx");
                }
                else {
                    Response.Redirect("CocinaListaPedidosWF.aspx");
                }
            }
        }


    }
}