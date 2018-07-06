using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class CocinaListaPedidosWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LlenarGrids();
            

        }

        protected void LlenarGrids() {

            ManejadorOrden orden = new ManejadorOrden();

            List<BLOrden> lista = new List<BLOrden>();

            lista = orden.DevolverPedidos();
            if (lista.Count > 0)
            {

                grdInfoOrden1.DataSource = lista;

                grdInfoOrden1.DataBind();

                orden.CantidadGridsLlenos += 1;

                lista = orden.DevolverPedidos();

                if (lista.Count > 0)
                {

                    grdInfoOrden2.DataSource = lista;

                    grdInfoOrden2.DataBind();

                    orden.CantidadGridsLlenos += 1;

                    lista = orden.DevolverPedidos();
                    if (lista.Count > 0)
                    {

                        grdInfoOrden3.DataSource = lista;

                        grdInfoOrden3.DataBind();

                        orden.CantidadGridsLlenos += 1;

                        lista = orden.DevolverPedidos();
                        if (lista.Count > 0)
                        {

                            grdInfoOrden4.DataSource = lista;

                            grdInfoOrden4.DataBind();

                            lista = orden.DevolverPedidos();
                            if (lista.Count > 0)
                            {

                                grdInfoOrden5.DataSource = lista;

                                grdInfoOrden5.DataBind();

                                orden.CantidadGridsLlenos += 1;

                            }
                        }
                    }

                }

            }      

         }

        protected void entregarBTN1_Click(object sender, EventArgs e)
        {

        }
        
    }
}