using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logConserjeria
    {
        #region sigleton
        private static readonly logConserjeria _instancia = new logConserjeria();
        public static logConserjeria Instancia
        {
            get
            {
                return logConserjeria._instancia;
            }
        }
        #endregion singleton
        public List<string> obtenerHabitacion()
        {
            return datConserjeria.Instancia.ObtenerHabitacion();
        }
        public List<string> obtenerEquipoTrabajo()
        {
            return datConserjeria.Instancia.ObtenerEquipoTrabajo();
        }
        public List<string> obtenerTipoOrden()
        {
            return datConserjeria.Instancia.ObtenerTipoOrden();
        }
        public List<entConserjeria> listarConserjeria()
        {
            return datConserjeria.Instancia.listarConserjeria();
        }
        public void agregaConserjeria(entConserjeria conserjeria)
        {
            datConserjeria.Instancia.agregaConserjeria(conserjeria);
        }
        public void deshabilitarConserjeria(entConserjeria conserjeria)
        {
            datConserjeria.Instancia.deshabilitarConserjeria(conserjeria);
        }
    }
}
