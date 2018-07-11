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

            rolesDDLagregar.Items.Add("Cocinero");
            rolesDDLagregar.Items.Add("Administrador");
            rolesDDLmodificar.Items.Add("Cocinero");
            rolesDDLmodificar.Items.Add("Administrador");

            string clave = Request.QueryString["Clave"];
           
        }

        protected void aceptarBTNagregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioTXTagregar.Text;
            string contrasena = contrasenaTXTagregar.Text;
            string rol = rolesDDLagregar.Text;  

            if (!nombreUsuario.Equals("") && !contrasena.Equals("") && !rol.Equals(""))
            {
                manejador.agregarUsuario(nombreUsuario, contrasena, rol);
            }
            else
            {

            }
        }

        protected void aceptarBTNeliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioTXTeliminar.Text;
            string contrasena = contrasenaTXTeliminar.Text;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                manejador.eliminarUsuario(nombreUsuario, contrasena);
            }
            else
            {

            }
        }

        protected void aceptarBTNconsultar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioTXTconsultar.Text;
            string contrasena = contrasenaTXTconsultar.Text;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                BLUsuario usuario = manejador.consultarUsuario(nombreUsuario, contrasena);
                consultaTXT.Text = "DATOS USUARIO:\n\t" + usuario.nombreUsuario + " Puesto: " + usuario.rol;
            }
            else
            {
                consultaTXT.Text = "DATOS USUARIO:\n\t NO SE HA ENCONTRADO EL USUARIO";
            }
        }

        protected void aceptarBTNmodificar_Click1(object sender, EventArgs e)
        {
            string nombreUsuario = nombreUsuarioTXTmodificar.Text;
            string contrasena = contrasenaTXTmodificar.Text;
            string rol = rolesDDLmodificar.Text;

            if (!nombreUsuario.Equals("") && !contrasena.Equals(""))
            {
                manejador.modificarUsuario(nombreUsuario, contrasena, rol);

            }
            else
            {

            }
        }
    }
}