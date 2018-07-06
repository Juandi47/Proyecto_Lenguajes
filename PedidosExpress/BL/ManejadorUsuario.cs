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


        public void agregarUsuario(BLUsuario usuario)
        {
            TOUsuario toUsuario = new TOUsuario(usuario.nombreUsuario, usuario.contrasennaUsuario, usuario.rol);
            daoUsuario.insertarUsuario(toUsuario);
        }

        public void eliminarUsuario(string identificacion)
        {
            daoUsuario.eliminarUsuario(identificacion);
        }

        public void modificarUsuario(string identificacion, string atributo, string nuevoValor)
        {
            daoUsuario.modificarUsuario(identificacion, atributo, nuevoValor);   
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
