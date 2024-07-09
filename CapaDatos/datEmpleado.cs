using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEmpleado
    {
        #region Singleton   
        // Patrón de Diseño Singleton
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia
        {
            get { return datEmpleado._instancia; }
        }
        #endregion
        public List<string> ObtenerGenero()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerGenero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["genero"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return categorias;
        }
        public List<string> ObtenerEstCiv()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerEstadoCivil", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["estadocivil"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return categorias;
        }
        public List<string> ObtenerTipoEmp()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["nombreTipoEmpleado"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return categorias;
        }
        public List<string> ObtenerEquipoTrabajo()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerEquipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["nombreET"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return categorias;
        }
        public List<entEmpleado> listarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    Emp.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                    Emp.DNI = dr["dniEmpleado"].ToString();
                    Emp.Nombre = dr["nombreEmpleado"].ToString();
                    Emp.Apellido = dr["apellidoEmpleado"].ToString();
                    Emp.Descripcion = dr["descripcionEmpleado"].ToString();
                    Emp.Fecha_Registro = Convert.ToDateTime(dr["fechaRegistroEmpleado"]);
                    Emp.Correo = dr["correoEmpleado"].ToString();
                    Emp.Telefono = dr["telefonoEmpleado"].ToString();
                    Emp.Estado = Convert.ToBoolean(dr["estadoEmpleado"]);
                    Emp.Pais = dr["lugarNaEmpleado"].ToString();
                    Emp.EstadoCivil = dr["estadocivil"].ToString();
                    Emp.Genero = dr["genero"].ToString();
                    Emp.EquipoTrabajo = dr["nombreET"].ToString();
                    Emp.Tipo = dr["nombreTipoEmpleado"].ToString();
                    lista.Add(Emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean agregarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniEmpleado", Emp.DNI);
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.Nombre);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", Emp.Apellido);
                cmd.Parameters.AddWithValue("@fechaRegistroEmpleado", Emp.Fecha_Registro);
                cmd.Parameters.AddWithValue("@correoEmpleado", Emp.Correo);
                cmd.Parameters.AddWithValue("@telefonoEmpleado", Emp.Telefono);
                cmd.Parameters.AddWithValue("@estadoEmpleado", Emp.Estado);
                cmd.Parameters.AddWithValue("@descripcionEmpleado", Emp.Descripcion);
                cmd.Parameters.AddWithValue("@lugarNaEmpleado", Emp.Pais);
                cmd.Parameters.AddWithValue("@estadocivil", Emp.EstadoCivil);
                cmd.Parameters.AddWithValue("@genero", Emp.Genero);
                cmd.Parameters.AddWithValue("@nombreTipoEmpleado", Emp.Tipo);
                cmd.Parameters.AddWithValue("@nombreET", Emp.EquipoTrabajo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public entEmpleado buscarEmpleado(int empID)
        {
            SqlCommand cmd = null;
            entEmpleado emp = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", empID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp = new entEmpleado();
                    emp.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                    emp.DNI = dr["dniEmpleado"].ToString();
                    emp.Nombre = dr["nombreEmpleado"].ToString();
                    emp.Apellido = dr["apellidoEmpleado"].ToString();
                    emp.Descripcion = dr["descripcionEmpleado"].ToString();
                    emp.Fecha_Registro = Convert.ToDateTime(dr["fechaRegistroEmpleado"]);
                    emp.Correo = dr["correoEmpleado"].ToString();
                    emp.Telefono = dr["telefonoEmpleado"].ToString();
                    emp.Estado = Convert.ToBoolean(dr["estadoEmpleado"]);
                    emp.Pais = dr["lugarNaEmpleado"].ToString();
                    emp.EstadoCivil = dr["estadocivil"].ToString();
                    emp.Genero = dr["genero"].ToString();
                    emp.EquipoTrabajo = dr["nombreET"].ToString();
                    emp.Tipo = dr["nombreTipoEmpleado"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return emp;
        }
        public Boolean deshabilitarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Emp.EmpleadoID);
                cmd.Parameters.AddWithValue("@estadoEmpleado", Emp.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        public Boolean editarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Emp.EmpleadoID);
                cmd.Parameters.AddWithValue("@dniEmpleado", Emp.DNI);
                cmd.Parameters.AddWithValue("@nombreEmpleado", Emp.Nombre);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", Emp.Apellido);
                cmd.Parameters.AddWithValue("@fechaRegistroEmpleado", Emp.Fecha_Registro);
                cmd.Parameters.AddWithValue("@correoEmpleado", Emp.Correo);
                cmd.Parameters.AddWithValue("@telefonoEmpleado", Emp.Telefono);
                cmd.Parameters.AddWithValue("@estadoEmpleado", Emp.Estado);
                cmd.Parameters.AddWithValue("@descripcionEmpleado", Emp.Descripcion);
                cmd.Parameters.AddWithValue("@lugarNaEmpleado", Emp.Pais);
                cmd.Parameters.AddWithValue("@estadocivil", Emp.EstadoCivil);
                cmd.Parameters.AddWithValue("@genero", Emp.Genero);
                cmd.Parameters.AddWithValue("@nombreTipoEmpleado", Emp.Tipo);
                cmd.Parameters.AddWithValue("@nombreET", Emp.EquipoTrabajo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
    }
}
