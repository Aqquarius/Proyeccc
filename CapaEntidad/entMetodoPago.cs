﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
