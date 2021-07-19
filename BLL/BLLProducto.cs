using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLProducto 
    {
        #region ADO CONECTADO
        public bool VerificarExistenciaProducto(int CodProducto)
        {
            MPPProducto oMPPProducto = new MPPProducto();
            return oMPPProducto.VerificarExistenciaProducto(CodProducto);
        }

        public List<BEProducto> LeerListaDeProductos()
        {
            MPPProducto oMPPProducto = new MPPProducto();
            return oMPPProducto.LeerListaDeProductos();
        }

        public bool Operacion(BEProducto oBEProducto, int CodOperacion)
        {
            MPPProducto oMPPProducto = new MPPProducto();
            return oMPPProducto.Operacion(oBEProducto, CodOperacion);
        }
        #endregion

        #region ADO DESCONECTADO
        public bool AltaProductoDesconectado(DataSet oDataSet, int Operacion)
        {
            MPPProducto oMPPProducto = new MPPProducto();
            return oMPPProducto.OperacionDesconectado(oDataSet, Operacion);
        }
        #endregion
    }
}
