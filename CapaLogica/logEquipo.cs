using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logEquipo
    {
        #region sigleton
        private static readonly logEquipo _instancia = new logEquipo();
        public static logEquipo Instancia
        {
            get
            {
                return logEquipo._instancia;
            }
        }
        #endregion singleton
        public List<CapaEntidad.entEquipo> listarEquipo()
        {
            return datEquipo.Instancia.listarEquipo();
        }
        public void agregaEquipo(entEquipo Equ)
        {
            datEquipo.Instancia.agregaEquipo(Equ);
        }
        public entEquipo buscarEquipo(int EquipoID)
        {
            return datEquipo.Instancia.buscarEquipo(EquipoID);
        }
        public void deshabilitarEquipo(entEquipo Equ)
        {
            datEquipo.Instancia.deshabilitarEquipo(Equ);
        }
        public void modificarEquipo(entEquipo Equ)
        {
            datEquipo.Instancia.modificarEquipo(Equ);
        }
    }
}