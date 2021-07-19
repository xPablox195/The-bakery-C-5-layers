using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELocalidad
    {
        public int CodLocalidad { get; set; }

        public string Nombre { get; set; }

        public int CodArea { get; set; }

        public override string ToString()
        {
            return CodLocalidad + " " + Nombre + " " + CodArea;
        }
    }
}
