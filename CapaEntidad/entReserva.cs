using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReserva
    {
        public int ReservaID { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public string Cliente { get; set; }
        public string Motivo_Viaje { get; set; }
        public string Habitacion { get; set; }
        public string Metodo_Pago { get; set; }
        public decimal Precio { get; set; }
        public Boolean Estado { get; set; }
    }
}
