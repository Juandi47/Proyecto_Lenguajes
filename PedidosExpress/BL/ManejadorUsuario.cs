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
            TOUsuario toUsuario = new TOUsuario(usuario.Identificacion, usuario.Nombre, usuario.Contrasenna, usuario.Rol);
            daoUsuario.insertarUsuario(toUsuario);
        }

        public void eliminarUsuario(string identificacion)
        {
            daoUsuario.eliminarUsuario(identificacion);
        }

        public BLUsuario buscarUsuario(string identificacion)
        {
            TOUsuario toUsuario = daoUsuario.buscarUsuario(identificacion);
            return null;
        }

        public void modificarUsuario(string identificacion, string nuevoValor, string atributo)
        {

        }
    }
}
