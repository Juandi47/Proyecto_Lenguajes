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
        BLPlato plato = new BLPlato();

        public BLPlato buscarPlato(string codigo) {
            DAOPlato daoPlato = new DAOPlato();
            
            TOPlato toPlato = daoPlato.consultarPlato(codigo);
            plato.codigoPlato = toPlato.codigoPlato;
            plato.nombrePlato = toPlato.nombrePlato;
            plato.descripcionPlato = toPlato.descripcionPlato;
            plato.precio = toPlato.precio;
            plato.estadoPlato = toPlato.descripcionPlato;
            plato.imagen = toPlato.imagen;
            
            return plato;
        }
    }
}
