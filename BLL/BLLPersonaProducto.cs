using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLPersonaProducto
    {
        public bool Operacion(BEPersonaProducto oBEPersonaProducto, int CodOperacion)
        {
            MPPPersonaCliente oMPPPersonaCliente = new MPPPersonaCliente();
            return oMPPPersonaCliente.Operacion(oBEPersonaProducto, CodOperacion);
        }

        public List<BEPersonaProducto> LeerListaDePersonaProducto()
        {
            MPPPersonaCliente oMPPPersonaProducto = new MPPPersonaCliente();
            return oMPPPersonaProducto.LeerListaDePersonaProducto();
        }
    }
}
