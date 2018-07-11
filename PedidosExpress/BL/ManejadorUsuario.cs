using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class ManejadorUsuario
    {
        public DAOUsuario daoUsuario = new DAOUsuario();


        public void agregarUsuario(string nombre, string contrasenna, string rol)
        {
           daoUsuario.insertarUsuario(nombre, contrasenna, rol);
        }

        public void eliminarUsuario(string nombre, string contrasenna)
        {
            daoUsuario.eliminarUsuario(nombre, contrasenna);
        }

        public void modificarUsuario(string nombre, string contrasenna,string rol)
        {
            daoUsuario.modificarUsuario(nombre, contrasenna, rol);   
        }

        Boolean existe;

        public BLUsuario consultarUsuario(string nombre, string contrasenna)
        {
            TOUsuario usuario = daoUsuario.buscarUsuario(nombre, contrasenna);
            BLUsuario usuarioBl = new BLUsuario(usuario.Nombre, usuario.Contrasenna, usuario.Rol);

            return usuarioBl;
        }


    }
}
