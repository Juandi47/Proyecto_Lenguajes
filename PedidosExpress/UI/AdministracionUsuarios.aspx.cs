using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AdministracionUsuarios1 : System.Web.UI.Page
    {

        ManejadorUsuario manejador;
        protected void Page_Load(object sender, EventArgs e)
        {
            manejador = new ManejadorUsuario();


            //rolesDDLagregar.Items.Add("Cocinero");
            //rolesDDLagregar.Items.Add("Administrador");
            //rolesDDLmodificar.Items.Add("Cocinero");
            //rolesDDLmodificar.Items.Add("Administrador");

            lista1.Items.Add("Cocinero");
            lista1.Items.Add("Administrador");
            lista2.Items.Add("Cocinero");
            lista2.Items.Add("Administrador");
            
        }

        protected void aceptarBTNagregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreAdd.Value;
            string contrasena = txtCedulaAdd.Value;
            string rol = lista1.Text;  

            if (!nombreUsuario.Equals("") && !contrasena.Equals("") && !rol.Equals(""))
            {
                manejador.agregarUsuario(nombreUsuario.ToLower(), contrasena, rol);
            }
            else
            {

            }
        }
        

        protected void aceptarBTNeliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreEli.Value;
            string contrasena = txtCedulaEli.Value;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                manejador.eliminarUsuario(nombreUsuario.ToLower(), contrasena);
            }
            else
            {

            }
        }

        protected void aceptarBTNconsultar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreBus.Value;
            string contrasena = txtCedulaBus.Value;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                BLUsuario usuario = manejador.consultarUsuario(nombreUsuario.ToLower(), contrasena);
                LabelPlatoBusqueda.InnerText = usuario.nombreUsuario + " Puesto: " + usuario.rol;
            }
            else
            {
                LabelPlatoBusqueda.InnerText = "NO SE HA ENCONTRADO EL USUARIO";
            }
        }

        protected void aceptarBTNagregar_Click1(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreAdd.Value;
            string contrasena = txtCedulaAdd.Value;
            string rol = lista2.Text;

            if (!nombreUsuario.Equals("") && !contrasena.Equals("") && !rol.Equals(""))
            {
                manejador.agregarUsuario(nombreUsuario.ToLower(), contrasena, rol);
            }
            else
            {

            }
        }

        protected void aceptarBTNmodificar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreMod.Value;
            string contrasena = txtCedulaMod.Value;
            string rol = lista2.Text;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                manejador.modificarUsuario(nombreUsuario.ToLower(), contrasena, rol);

            }
            else
            {

            }
        }
    }
}