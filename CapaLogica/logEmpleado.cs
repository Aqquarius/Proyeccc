using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logEmpleado
    {
        #region sigleton
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton
        public List<string> obtenerGenero()
        {
            return datEmpleado.Instancia.ObtenerGenero();
        }
        public List<string> obtenerEstadoCivil()
        {
            return datEmpleado.Instancia.ObtenerEstCiv();
        }
        public List<string> obtenerTipoEmpleado()
        {
            return datEmpleado.Instancia.ObtenerTipoEmp();
        }
        public List<string> obtenerEquipoTrabajo()
        {
            return datEmpleado.Instancia.ObtenerEquipoTrabajo();
        }
        public List<CapaEntidad.entEmpleado> listarEmpleado()
        {
            return datEmpleado.Instancia.listarEmpleado();
        }
        public void agregarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.agregarEmpleado(Emp);
        }
        public entEmpleado buscarEmpleado(int EmpID)
        {
            return datEmpleado.Instancia.buscarEmpleado(EmpID);
        }
        public void deshabilitarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.deshabilitarEmpleado(Emp);
        }
        public void modificarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.editarEmpleado(Emp);
        }
    }
}
