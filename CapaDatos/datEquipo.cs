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
    public class datEquipo
    {
        public string connectionString = "Server=DESKTOP-ASOD6JO\\SQLEXPRESS;Database=hostalLosAlcanfores;Integrated Security=True;";

        #region sigleton
        private static readonly datEquipo _instancia = new datEquipo();
        public static datEquipo Instancia
        {
            get
            {
                return datEquipo._instancia;
            }
        }
        #endregion singleton
        public List<entEquipo> listarEquipo()
        {
            SqlCommand cmd = null;
            List<entEquipo> lista = new List<entEquipo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEquipo Cli = new entEquipo();
                    Cli.EquipoID = Convert.ToInt32(dr["EquipotrabajoID"]);
                    Cli.Nombre = dr["nombreET"].ToString();
                    Cli.Estado = Convert.ToBoolean(dr["estadoET"]);
                    lista.Add(Cli);
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
        public Boolean agregaEquipo(entEquipo Equ)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregaEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreET", Equ.Nombre);
                cmd.Parameters.AddWithValue("@estadoET", Equ.Estado);
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
        public entEquipo buscarEquipo(int equipoID)
        {
            SqlCommand cmd = null;
            entEquipo equipo = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipotrabajoID", equipoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    equipo = new entEquipo();
                    equipo.EquipoID = Convert.ToInt32(dr["EquipotrabajoID"]);
                    equipo.Nombre = dr["nombreET"].ToString();
                    equipo.Estado = Convert.ToBoolean(dr["estadoET"]);
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
            return equipo;
        }
        public Boolean deshabilitarEquipo(entEquipo Equ)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipotrabajoID", Equ.EquipoID);
                cmd.Parameters.AddWithValue("@estadoET", Equ.Estado);
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
        public Boolean modificarEquipo(entEquipo Equ)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarEquipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EquipotrabajoID", Equ.EquipoID);
                cmd.Parameters.AddWithValue("@nombreET", Equ.Nombre);
                cmd.Parameters.AddWithValue("@estadoET", Equ.Estado);
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