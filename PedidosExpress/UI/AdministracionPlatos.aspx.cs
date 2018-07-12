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
            
            BLPlato plato = manejador.buscarPlato(txtCodigoBus.Value);
            if (plato.codigoPlato.Equals(""))
            {
                Response.Redirect("AdministracionPlatos.aspx");
            }
            else {
                LabelPlatoBusqueda.InnerText = plato.informacion();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (manejador.modificarPlato(txtCodigoMod.Value, txtNombreMod.Value, txtDescripcionMod.Value, txtPrecioMod.Value, txtEstadoMod.Value, txtImagenMod.Value) > 0)
            {
                string modificado = "Modificado";
            }
            else {
                string error = "Error";
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (manejador.agregarPlato(txtCodigoAdd.Value, txtNombreAdd.Value, txtDescripcionAdd.Value, txtPrecioAdd.Value, txtEstadoAdd.Value, txtImagenAdd.Value) > 0)
            {
                string agregado = "Agregado";
            }
            else {
                string err = "Error";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (manejador.eliminarPlato(txtCodigoEli.Value) > 0)
            {
            }
            else {

            }
        }
    }
}