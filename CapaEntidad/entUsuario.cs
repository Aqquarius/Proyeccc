using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int ClienteID { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_registro { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
}
