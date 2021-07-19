using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace MPP
{
    public class MPPPersonaCliente
    {
        public bool Operacion(BEPersonaProducto oBEPersonaProducto, int CodOperacion)
        {
            Hashtable oHastable = new Hashtable();
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "altaPersona_Producto";
                    break;
                default:
                    consulta = null;
                    break;
            }


            oHastable.Add("@CodPersona", oBEPersonaProducto.CodPersona);
            oHastable.Add("@CodProducto", oBEPersonaProducto.CodProducto);

            return oAcceso.Operacion(oHastable, consulta);
        }

        public List<BEPersonaProducto> LeerListaDePersonaProducto()
        {
            Acceso oAcceso = new Acceso();
            DataSet oDataSet = new DataSet();
            oDataSet = oAcceso.LeerLista("LeerListaDePersonaProducto");
            List<BEPersonaProducto> ListaDePersonaProducto = new List<BEPersonaProducto>();
            if (oDataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    BEPersonaProducto oBEPersonaProducto = new BEPersonaProducto();
                    oBEPersonaProducto.CodPersona = Convert.ToInt32(Item[0]);
                    oBEPersonaProducto.CodProducto = Convert.ToInt32(Item[1]);
                    ListaDePersonaProducto.Add(oBEPersonaProducto);
                }
            }

            if (ListaDePersonaProducto.Count != 0)
            {
                return ListaDePersonaProducto;
            }
            else
            {
                return null;
            }
        }
    }
}
