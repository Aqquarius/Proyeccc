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
    public class datHabitacion
    {
        public string connectionString = "Server= DESKTOP-O07559K\\SQLEXPRESS; Database = hostalLosAlcanfores;" + "Integrated Security=true";

        #region Singleton   
        private static readonly datHabitacion _instancia = new datHabitacion();
        public static datHabitacion Instancia
        {
            get { return datHabitacion._instancia; }
        }
        #endregion

        public List<string> ObtenerPiso()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerPiso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["piso"].ToString());
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

        public List<string> ObtenerTipo()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["tipoHabitacion"].ToString());
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

        public List<entHabitacion> listarHabitacion()
        {
            SqlCommand cmd = null;
            List<entHabitacion> lista = new List<entHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitacion Hab = new entHabitacion();
                    Hab.HabitacionID = Convert.ToInt32(dr["HabitacionID"]);
                    Hab.Piso = dr["piso"].ToString();
                    Hab.Numero = dr["numeroHabitacion"].ToString();
                    Hab.Tipo = dr["tipoHabitacion"].ToString();
                    Hab.Precio = Convert.ToDecimal(dr["precioHabitacion"]);
                    Hab.Estado = Convert.ToBoolean(dr["estadoHabitacion"]);
                    lista.Add(Hab);
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

        public void agregarHabitacion(entHabitacion habitacion)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroHabitacion", habitacion.Numero);
                cmd.Parameters.AddWithValue("@precioHabitacion", habitacion.Precio);
                cmd.Parameters.AddWithValue("@piso", habitacion.Piso);
                cmd.Parameters.AddWithValue("@tipoHabitacion", habitacion.Tipo);
                cmd.Parameters.AddWithValue("@estadoHabitacion", habitacion.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
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
        }

        public entHabitacion buscarHabitacion(int? habitacionID, string numero)
        {
            SqlCommand cmd = null;
            entHabitacion habitacion = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (habitacionID.HasValue)
                {
                    cmd.Parameters.AddWithValue("@HabitacionID", habitacionID.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@HabitacionID", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@numeroHabitacion", string.IsNullOrEmpty(numero) ? (object)DBNull.Value : numero);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    habitacion = new entHabitacion();
                    habitacion.HabitacionID = Convert.ToInt32(dr["HabitacionID"]);
                    habitacion.Piso = dr["piso"].ToString();
                    habitacion.Numero = dr["numeroHabitacion"].ToString();
                    habitacion.Tipo = dr["tipoHabitacion"].ToString();
                    habitacion.Precio = Convert.ToDecimal(dr["precioHabitacion"]);
                    habitacion.Estado = Convert.ToBoolean(dr["estadoHabitacion"]);
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
            return habitacion;
        }


        public Boolean modificarHabitacion(entHabitacion habitacion)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HabitacionID", habitacion.HabitacionID);
                cmd.Parameters.AddWithValue("@numeroHabitacion", habitacion.Numero);
                cmd.Parameters.AddWithValue("@precioHabitacion", habitacion.Precio);
                cmd.Parameters.AddWithValue("@piso", habitacion.Piso);
                cmd.Parameters.AddWithValue("@tipoHabitacion", habitacion.Tipo);
                cmd.Parameters.AddWithValue("@estadoHabitacion", habitacion.Estado);
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
        public Boolean deshabilitarHabitacion(entHabitacion Hab)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HabitacionID", Hab.HabitacionID);
                cmd.Parameters.AddWithValue("@estadoHabitacion", Hab.Estado);
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

    }
}
