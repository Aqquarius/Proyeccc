using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public int EmpleadoID { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        //comboBoxes
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }
        public string Tipo { get; set; }
        public string EquipoTrabajo { get; set; }
    }
}
