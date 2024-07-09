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
    public class datMetodoPago
    {
        public string connectionString = "Server=DESKTOP-ASOD6JO\\SQLEXPRESS;Database=hostalLosAlcanfores;Integrated Security=True;";

        #region Singleton   
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        public static datMetodoPago Instancia
        {
            get { return datMetodoPago._instancia; }
        }
        #endregion
        public List<entMetodoPago> listaMP()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago Mp = new entMetodoPago();
                    Mp.MetodoPagoID = Convert.ToInt32(dr["MetodoPagoID"]);
                    Mp.Nombre = dr["nombreMetPag"].ToString();
                    Mp.Descripcion = dr["descripcionMetPag"].ToString();
                    Mp.Estado = Convert.ToBoolean(dr["estadoMetPag"]);
                    lista.Add(Mp);
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
        public Boolean agregaMP(entMetodoPago Mp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMetPag", Mp.Nombre);
                cmd.Parameters.AddWithValue("@descripcionMetPag", Mp.Descripcion);
                cmd.Parameters.AddWithValue("@estadoMetPag", Mp.Estado);
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
        public entMetodoPago buscarMP(int mpID)
        {
            SqlCommand cmd = null;
            entMetodoPago mp = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoPagoID", mpID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    mp = new entMetodoPago();
                    mp.MetodoPagoID = Convert.ToInt32(dr["MetodoPagoID"]);
                    mp.Nombre = dr["nombreMetPag"].ToString();
                    mp.Descripcion = dr["descripcionMetPag"].ToString();
                    mp.Estado = Convert.ToBoolean(dr["estadoMetPag"]);
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
            return mp;
        }
        public Boolean deshabilitarMP(entMetodoPago Mp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoPagoID", Mp.MetodoPagoID);
                cmd.Parameters.AddWithValue("@estadoMetPag", Mp.Estado);
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
        public Boolean modificarMP(entMetodoPago Mp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoPagoID", Mp.MetodoPagoID);
                cmd.Parameters.AddWithValue("@nombreMetPag", Mp.Nombre);
                cmd.Parameters.AddWithValue("@descripcionMetPag", Mp.Descripcion);
                cmd.Parameters.AddWithValue("@estadoMetPag", Mp.Estado);
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
