using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente : BEPersona
    {
        public decimal TotalCompra { get; set; }

        public string MétodoDePago { get; set; }

        //public List<BEProducto> L {get; set; };
    }
}
