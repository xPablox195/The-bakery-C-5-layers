using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace MPP
{
    public class MPPProducto
    {
        public bool VerificarExistenciaProducto(int CodProducto)
        {
            Acceso oAcceso = new Acceso();
            Hashtable oHashtable = new Hashtable();
            oHashtable.Add("@CodProducto", CodProducto);
            return oAcceso.LeerEscalar("verificarExistenciaProductoCod", oHashtable);
        }

        public List<BEProducto> LeerListaDeProductos()
        {
            Acceso oAcceso = new Acceso();
            DataSet oDataSet = new DataSet();
            oDataSet = oAcceso.LeerLista("LeerListaDeProductos");
            List<BEProducto> ListaDeProductos = new List<BEProducto>();
            if (oDataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.CodProducto = Convert.ToInt32(Item[0]);
                    oBEProducto.Nombre = Item[1].ToString();
                    oBEProducto.Tipo = Item[2].ToString();
                    oBEProducto.Precio = Convert.ToInt32(Item[3]);
                    ListaDeProductos.Add(oBEProducto);
                }
            }

            if (ListaDeProductos.Count != 0)
            {
                return ListaDeProductos;
            }
            else
            {
                return null;
            }
        }

        public bool Operacion(BEProducto oBEProducto, int CodOperacion)
        {
            Hashtable oHastable = new Hashtable();
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "altaProducto";
                    break;
                case 2:
                    consulta = "modificarProducto";
                    break;
                case 3:
                    consulta = "eliminarProducto";
                    break;
                default:
                    consulta = null;
                    break;
            }

            if (CodOperacion == 1 || CodOperacion == 2)
            {
                oHastable.Add("@CodProducto", oBEProducto.CodProducto);
                oHastable.Add("@Nombre", oBEProducto.Nombre);
                oHastable.Add("@Tipo", oBEProducto.Tipo);
                oHastable.Add("@Precio", oBEProducto.Precio);
            }
            else
            {
                oHastable.Add("@CodProducto", oBEProducto.CodProducto);

            }
            return oAcceso.Operacion(oHastable, consulta);
        }

        public bool OperacionDesconectado(DataSet oDataSet, int CodOperacion)
        {
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "Producto"; // se le pasa el nombre de la tabla a actualizar
                    break;
                //case 2:
                //    consulta = "modificarProducto"; 
                //    break;
                //case 3:
                //    consulta = "eliminarProducto";
                //    break;
                default:
                    consulta = null;
                    break;
            }
           return oAcceso.AltaDesconectadoProductos(oDataSet, consulta);
        }
    }
}
