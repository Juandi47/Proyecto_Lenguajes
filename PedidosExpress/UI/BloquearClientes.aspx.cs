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

            labelbloquear.Text = manejador.bloquearCliente(txtBloquear.Text);
            
        }

        protected void btnVerEstado_Click(object sender, EventArgs e)
        {
            labelEstado.Text = manejador.verEstadoCliente(txtBuscarCliente.Text);
        }

        protected void btnDesbloquear_Click(object sender, EventArgs e)
        {
                labelDesbloquear.Text = manejador.desbloquearCliente(txtDesbloquear.Text);
            
        }
    }
}