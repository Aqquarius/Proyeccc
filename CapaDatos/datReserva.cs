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
    public class datReserva
    {
        #region singleton
        private static readonly datReserva _instancia = new datReserva();
        public static datReserva Instancia
        {
            get { return datReserva._instancia; }
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
        public List<string> ObtenerMP()
        {
            List<string> clientes = new List<string>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObtenerMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clientes.Add(dr["nombreMetPag"].ToString());
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
        public List<entReserva> listarReserva()
        {
            SqlCommand cmd = null;
            List<entReserva> lista = new List<entReserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReserva res = new entReserva();
                    res.ReservaID = Convert.ToInt32(dr["OrdenreservaID"]);
                    res.Cliente = dr["dniCliente"].ToString();
                    res.Habitacion = dr["numeroHabitacion"].ToString();
                    res.Metodo_Pago = dr["nombreMetPag"].ToString();
                    res.Estado = Convert.ToBoolean(dr["estadoReserva"]);
                    res.Motivo_Viaje = dr["motivoViajeRes"].ToString();
                    res.Precio = Convert.ToDecimal(dr["precioRes"]);
                    res.Fecha_Registro = Convert.ToDateTime(dr["fechaRegistroRes"]);
                    res.Fecha_Entrada = Convert.ToDateTime(dr["fechaEntradaRes"]);
                    res.Fecha_Salida = Convert.ToDateTime(dr["fechaSalidaRes"]);
                    lista.Add(res);
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
        public Boolean agregaReserva(entReserva Res)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregaReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", Res.Cliente);
                cmd.Parameters.AddWithValue("@numeroHabitacion", Res.Habitacion);
                cmd.Parameters.AddWithValue("@nombreMetPag", Res.Metodo_Pago);
                cmd.Parameters.AddWithValue("@estadoReserva", Res.Estado);
                cmd.Parameters.AddWithValue("@motivoViajeRes", Res.Motivo_Viaje);
                cmd.Parameters.AddWithValue("@precioRes", Res.Precio);
                cmd.Parameters.AddWithValue("@fechaRegistroRes", Res.Fecha_Registro);
                cmd.Parameters.AddWithValue("@fechaEntradaRes", Res.Fecha_Entrada);
                cmd.Parameters.AddWithValue("@fechaSalidaRes", Res.Fecha_Salida);
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
        public Boolean deshabilitarReserva(entReserva Res)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenreservaID", Res.ReservaID);
                cmd.Parameters.AddWithValue("@estadoReserva", Res.Estado);
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
