using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class AdministracionPlatos : System.Web.UI.Page

    {

        ManejadorPlato manejador = new ManejadorPlato();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            BLPlato plato = manejador.buscarPlato(txtPlato.Text);
            if (plato.codigoPlato.Equals(""))
            {
                Response.Redirect("AdministracionPlatos.aspx");
            }
            else {
                LabelPlato.Text = plato.informacion();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (manejador.modificarPlato(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtPrecio.Text, txtEstado.Text, txtImagen.Text) > 0)
            {
                string modificado = "Modificado";
            }
            else {
                string error = "Error";
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (manejador.agregarPlato(txtCodAgregar.Text, txtNomAgregar.Text, txtDesAgregar.Text, txtPreAgregar.Text, txtEstAgregar.Text, txtImaAgregar.Text) > 0)
            {
                string agregado = "Agregado";
            }
            else {
                string err = "Error";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (manejador.eliminarPlato(txtEliminar.Text) > 0)
            {
            }
            else {

            }
        }
    }
}