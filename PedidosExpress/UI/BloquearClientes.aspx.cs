using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class BloquearClientes : System.Web.UI.Page
    {
        ManejadorCliente manejador = new ManejadorCliente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBloquear_Click(object sender, EventArgs e)
        {

            string bloqueado;
            if (manejador.bloquearCliente(txtBloquear.Text) > 0)
            {
                bloqueado = "Ha sido bloqueado";
            }
            else {
                bloqueado = "No ha sido bloqueado";
            }
        }

        protected void btnVerEstado_Click(object sender, EventArgs e)
        {
            labelEstado.Text = manejador.verEstadoCliente(txtBuscarCliente.Text);
        }
    }
}