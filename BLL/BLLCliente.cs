using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLCliente : BLLPersona
    {
        public bool Operacion(BECliente oBECLiente, int CodOperacion)
        {
            MPPCliente oMPPCliente = new MPPCliente();
            return oMPPCliente.Operacion(oBECLiente, CodOperacion);
        }

        public BECliente LeerClienteFiltradoPorDNI (int DNI)
        {
            MPPCliente oMPPCliente = new MPPCliente();
            return oMPPCliente.LeerClienteFiltroPorDNI(DNI);
        }

        public override decimal MontoTotal()
        {
            MPPCliente oMPPCliente = new MPPCliente();
            List<BECliente> ListaDeClientes = new List<BECliente>();
            ListaDeClientes = oMPPCliente.LeerListaDeClientes();
            if (ListaDeClientes != null)
            {
                decimal totalRecaudado = 0;
                foreach (BECliente Cliente in ListaDeClientes)
                {
                    totalRecaudado += Cliente.TotalCompra;

                }
                return totalRecaudado;
            }
            else
            {
                return 0;
            } 
        }
    }
}
