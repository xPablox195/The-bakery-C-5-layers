using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPCliente
    {
        public bool Operacion(BECliente oBECliente, int CodOperacion)
        {
            Hashtable oHastable = new Hashtable();
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "altaCliente";
                    break;
                default:
                    consulta = null;
                    break;
            }


            oHastable.Add("@DNI", oBECliente.DNI);
            oHastable.Add("@TotalCompra", oBECliente.TotalCompra);
            oHastable.Add("@MetodoPago", oBECliente.MétodoDePago);


            return oAcceso.Operacion(oHastable, consulta);
        }

        public List<BECliente> LeerListaDeClientes()
        {
            Acceso oAcceso = new Acceso();
            DataSet oDataSet = new DataSet();
            List<BECliente> ListaDeClientes = new List<BECliente>();
            oDataSet = oAcceso.LeerLista("leerListaDeClientes");

            if (oDataSet.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    BECliente oBECliente = new BECliente();
                    oBECliente.CodPersona = Convert.ToInt32(Item[0]);
                    oBECliente.DNI = Convert.ToInt32(Item[1]);
                    oBECliente.MétodoDePago = Item[2].ToString();
                    oBECliente.TotalCompra = Convert.ToDecimal(Item[3]);
                    ListaDeClientes.Add(oBECliente);
                }
            }

            if (ListaDeClientes.Count != 0)
            {
                return ListaDeClientes;
            }
            else
            {
                return null;
            }
        }

        public BECliente LeerClienteFiltroPorDNI(int DNI)
        {
            Acceso oAcceso = new Acceso();
            DataSet oDataSet = new DataSet();
            BECliente oBECliente = new BECliente();

            Hashtable oHastable = new Hashtable();
            oHastable.Add("@DNI", DNI);
            oDataSet = oAcceso.LeerEscalarDevolverEscalar("leerClienteFiltroPorDNI", oHastable);

            if (oDataSet.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    
                    oBECliente.CodPersona = Convert.ToInt32(Item[0]);
                    oBECliente.DNI = Convert.ToInt32(Item[1]);
                    oBECliente.MétodoDePago = Item[2].ToString();
                    oBECliente.TotalCompra = Convert.ToDecimal(Item[3]);
                }
            }

            if (oBECliente.DNI != 0)
            {
                return oBECliente;
            }
            else
            {
                return null;
            }
        }
    }
}
