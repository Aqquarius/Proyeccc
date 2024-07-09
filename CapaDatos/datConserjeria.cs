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
    public class datConserjeria
    {
        #region singleton
        private static readonly datConserjeria _instancia = new datConserjeria();
        public static datConserjeria Instancia
        {
            get { return datConserjeria._instancia; }
        }
        #endregion singleton
        public List<string> ObtenerHabitacion()
        {
            List<string> clientes = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clientes.Add(dr["numeroHabitacion"].ToString());
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
            return clientes;
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
        public List<string> ObtenerTipoOrden()
        {
            List<string> categorias = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerTipoOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categorias.Add(dr["tipoOrden"].ToString());
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
        public List<entConserjeria> listarConserjeria()
        {
            SqlCommand cmd = null;
            List<entConserjeria> lista = new List<entConserjeria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaConserjeria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entConserjeria con = new entConserjeria();
                    con.ConserjeriaID = Convert.ToInt32(dr["OrdenconserjeríaID"]);
                    con.Cliente = dr["dniCliente"].ToString();
                    con.Habitacion = dr["numeroHabitacion"].ToString();
                    con.Equipo = dr["nombreET"].ToString();
                    con.Tipo_Orden = dr["tipoOrden"].ToString();
                    con.Estado = Convert.ToBoolean(dr["estadoOrden"]);
                    con.Fecha_Orden = Convert.ToDateTime(dr["fechaOrdenConserjeria"]);
                    lista.Add(con);
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
        public Boolean agregaConserjeria(entConserjeria Con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregaConserjeria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", Con.Cliente);
                cmd.Parameters.AddWithValue("@numeroHabitacion", Con.Habitacion);
                cmd.Parameters.AddWithValue("@nombreET", Con.Equipo);
                cmd.Parameters.AddWithValue("@tipoOrden", Con.Tipo_Orden);
                cmd.Parameters.AddWithValue("@estadoOrden", Con.Estado);
                cmd.Parameters.AddWithValue("@fechaOrdenConserjeria", Con.Fecha_Orden);
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
        public Boolean deshabilitarConserjeria(entConserjeria Con)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaConserjeria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenconserjeríaID", Con.ConserjeriaID);
                cmd.Parameters.AddWithValue("@estadoOrden", Con.Estado);
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
