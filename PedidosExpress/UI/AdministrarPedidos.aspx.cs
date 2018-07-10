using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class AdministrarPedidos : System.Web.UI.Page
    {
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnVerTodosClientes_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //List<BLCliente> elCliente = new List<BLCliente>();
            //ManejadorCliente manejadorCliente = new ManejadorCliente();
            //if (checkHabilitarCliente.Checked)
            //{
            //    BLCliente cliente = manejadorCliente.buscarCliente(txtBuscarPorCliente.Text);
            //    if (cliente.nombre.Equals(""))
            //    {
            //        string muestra = "El cliente no cin cedula " + txtBuscarPorCliente.Text + " no se encuentra registrado en el sistema";
            //    }
            //    else {
            //        elCliente.Add(cliente);
            //        grdClientes.DataSource = elCliente;
            //        grdClientes.DataBind();
            //    }
            //}
            //else {
            //    string mostrar = "Debe habilitar el filtro"; 
            //}
        }

        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {

        }
    }
}