using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logReserva
    {
        #region sigleton
        private static readonly logReserva _instancia = new logReserva();
        public static logReserva Instancia
        {
            get
            {
                return logReserva._instancia;
            }
        }
        #endregion singleton
        public List<string> obtenerHabitacion()
        {
            return datReserva.Instancia.ObtenerHabitacion();
        }
        public List<string> obtenerMP()
        {
            return datReserva.Instancia.ObtenerMP();
        }
        public List<entReserva> listarReserva()
        {
            return datReserva.Instancia.listarReserva();
        }
        public void agregarReserva(entReserva reserva)
        {
            datReserva.Instancia.agregaReserva(reserva);
        }
        public void deshabilitarReserva(entReserva reserva)
        {
            datReserva.Instancia.deshabilitarReserva(reserva);
        }
    }
}
