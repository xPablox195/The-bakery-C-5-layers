﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEmpleado : BEPersona
    {
        public decimal Sueldo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public BELocalidad Localidad { get; set; }


    }
}
