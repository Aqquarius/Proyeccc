using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaLogica
{
    public class logUsuario
    {
        #region sigleton
        private static readonly logUsuario _instancia = new logUsuario();
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<CapaEntidad.entUsuario> listarUsuario()
        {
            return datUsuario.Instancia.listarUsuario();
        }
        public void insertaCliente(entUsuario Cli)
        {
            datUsuario.Instancia.insertaCliente(Cli);
        }
        public void deshabilitarCliente(entUsuario Cli)
        {
            datUsuario.Instancia.deshabilitarCliente(Cli);
        }
        #endregion metodos


    }
}
