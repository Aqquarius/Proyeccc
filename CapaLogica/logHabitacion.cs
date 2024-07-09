using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logHabitacion
    {
        #region singleton
        private static readonly logHabitacion _instancia = new logHabitacion();
        public static logHabitacion Instancia
        {
            get
            {
                return logHabitacion._instancia;
            }
        }
        #endregion singleton

        public List<entHabitacion> listarHabitacion()
        {
            return datHabitacion.Instancia.listarHabitacion();
        }

        public List<string> obtenerPiso()
        {
            return datHabitacion.Instancia.ObtenerPiso();
        }

        public List<string> obtenerTipo()
        {
            return datHabitacion.Instancia.ObtenerTipo();
        }

        public void agregarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instancia.agregarHabitacion(habitacion);
        }

        public entHabitacion buscarHabitacion(int habitacionID, string numero)
        {
            return datHabitacion.Instancia.buscarHabitacion(habitacionID,numero);
        }

        public void modificarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instancia.modificarHabitacion(habitacion);
        }

        public void deshabilitarHabitacion(entHabitacion Hab)
        {
            datHabitacion.Instancia.deshabilitarHabitacion(Hab);
        }
    }
}
