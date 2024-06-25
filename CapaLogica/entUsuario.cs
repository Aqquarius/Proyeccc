using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaLogica
{
    public class entUsuario
    {
        #region sigleton
        private static readonly entUsuario _instancia = new entUsuario();
        public static entUsuario Instancia
        {
            get
            {
                return entUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<CapaEntidad.entUsuario> listarUsuario()
        {
            return datUsuario.Instancia.listarUsuario();
        }
        #endregion metodos
    }
}
