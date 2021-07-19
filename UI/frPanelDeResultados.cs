using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frPanelDeResultados : Form
    {
        public frPanelDeResultados()
        {
            InitializeComponent();
        }

        BLLPersonaProducto oBLLPersonaProducto = new BLLPersonaProducto();
        BLLProducto oBLLProducto = new BLLProducto();
        List<BEPersonaProducto> ListaDePersonaProductos = new List<BEPersonaProducto>();
        List<BEProducto> ListaDeProductos = new List<BEProducto>();
        List<BEProducto> ListaDeProductosFiltrado = new List<BEProducto>();
        int[] arrayFiltrado;
        private void frPanelDeResultados_Load(object sender, EventArgs e)
        {
            ListaDePersonaProductos = oBLLPersonaProducto.LeerListaDePersonaProducto();
            ListaDeProductos = oBLLProducto.LeerListaDeProductos();
            chart1.DataSource = ListaDeProductosVendidos();
            chart1.DataBind();

        }

        public List<BEProducto> ListaDeProductosVendidos()
        {
            if(ListaDePersonaProductos.Count != 0)
            {
                arrayFiltrado = new int[ListaDePersonaProductos.Count];
                foreach(BEPersonaProducto oBEPersonaProducto in ListaDePersonaProductos) //BUSCAR PERSONAPRODUCTO
                {
                    foreach(BEProducto oBEProducto in ListaDeProductos) //BUSCAR PRODUCTO
                    {
                        if(oBEPersonaProducto.CodProducto == oBEProducto.CodProducto) //SI COINCIDEN AGREGAR?
                        {
                            if(ListaDeProductosFiltrado.Count != 0)
                            {
                                if(!Existencia(ListaDeProductosFiltrado, oBEProducto)) //SI NO EXISTE OTRO IGUAL EN PRODUCTO FILTRADO AGREGA
                                {
                                    ListaDeProductosFiltrado.Add(oBEProducto);
                                }
                            }
                        }
                    }
                }
                return ListaDeProductosFiltrado;
            }
            else
            {
                return null;
            }
        } 

        public bool Existencia(List<BEProducto> ListaBuscar, BEProducto oProductBucar)
        {
            if(ListaBuscar.Count != 0)
            {
                foreach(BEProducto oP in ListaBuscar)
                {
                    if(oProductBucar.CodProducto == oP.CodProducto)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

    }
}
