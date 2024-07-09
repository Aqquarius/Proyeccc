using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entConserjeria
    {
        public int ConserjeriaID { get; set; }
        public DateTime Fecha_Orden { get; set; }
        public string Cliente { get; set; }
        public string Tipo_Orden { get; set; }
        public string Habitacion { get; set; }
        public string Equipo { get; set; }
        public Boolean Estado { get; set; }
    }
}
