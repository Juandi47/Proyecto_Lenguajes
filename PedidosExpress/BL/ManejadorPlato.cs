using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorPlato
    {
        DAOPlato daoPlato = new DAOPlato();
        BLPlato plato = new BLPlato();

        public BLPlato buscarPlato(string codigo) {
            
            TOPlato toPlato = daoPlato.consultarPlato(codigo);
            plato.codigoPlato = toPlato.codigoPlato;
            plato.nombrePlato = toPlato.nombrePlato;
            plato.descripcionPlato = toPlato.descripcionPlato;
            plato.precio = toPlato.precio;
            plato.estadoPlato = toPlato.descripcionPlato;
            plato.imagen = toPlato.imagen;
            
            return plato;
        }

        public List<BLPlato> listaPlatos() {
            List<TOPlato> to = new List<TOPlato>();
            DAOPlato dao = new DAOPlato();
            List<BLPlato> lista = new List<BLPlato>();

            to = dao.consultarPlatos();

            foreach (TOPlato x in to) {
                lista.Add(new BLPlato(x.codigoPlato,x.nombrePlato,x.descripcionPlato,x.precio,x.estadoPlato,x.imagen));
            }
            return lista;
        }


        public int modificarPlato(string codigo, string nombre, string descripcion, string precio, string estado, string imagen) {
           return daoPlato.modificarPlato(codigo,  nombre,  descripcion,  precio,  estado,  imagen);
        }


        public int agregarPlato(string codigo, string nombre, string descripcion, string precio, string estado, string imagen) {
            return daoPlato.agregarPlato( codigo,  nombre,  descripcion,  precio,  estado,  imagen);
        }


        public int eliminarPlato(string codigo) {
            return daoPlato.eliminarPlato(codigo);
        }
    }
}
