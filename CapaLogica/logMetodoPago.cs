using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region sigleton
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        public List<CapaEntidad.entMetodoPago> listarMetPag()
        {
            return datMetodoPago.Instancia.listaMP();
        }
        public void agregarMetPag(entMetodoPago Mp)
        {
            datMetodoPago.Instancia.agregaMP(Mp);
        }
        public entMetodoPago buscarMetPag(int mpID)
        {
            return datMetodoPago.Instancia.buscarMP(mpID);
        }
        public void deshabilitarMetPag(entMetodoPago Mp)
        {
            datMetodoPago.Instancia.deshabilitarMP(Mp);
        }
        public void modificarMetPag(entMetodoPago Mp)
        {
            datMetodoPago.Instancia.modificarMP(Mp);
        }
    }
}
