using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entHabitacion
    {
        public int HabitacionID { get; set; }
        public string Piso { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public Boolean Estado { get; set; }
    }
}
