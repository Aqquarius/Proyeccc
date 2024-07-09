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
    public class datUsuario
    {
        #region Singleton   
        // Patrón de Diseño Singleton
        private static readonly datUsuario _instancia = new datUsuario();
        public static datUsuario Instancia
        {
            get { return datUsuario._instancia; }
        }
        #endregion
        public List<entUsuario> listarUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario Usu = new entUsuario();
                    Usu.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Usu.DNI = dr["dniCliente"].ToString();
                    Usu.Nombre = dr["nombreCliente"].ToString();
                    Usu.Apellido = dr["apellidoCliente"].ToString();
                    Usu.Descripcion = dr["descripcionCliente"].ToString();
                    Usu.Fecha_Registro = Convert.ToDateTime(dr["fechaRegistroCliente"]);
                    Usu.Correo = dr["correoCliente"].ToString();
                    Usu.Telefono = dr["telefonoCliente"].ToString();
                    Usu.Estado = Convert.ToBoolean(dr["estadoCliente"]);
                    Usu.Pais = dr["lugarNaCliente"].ToString();
                    Usu.EstadoCivil = dr["estadocivil"].ToString();
                    Usu.Genero = dr["genero"].ToString();
                    lista.Add(Usu);
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
        public Boolean insertaCliente(entUsuario Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente", Cli.DNI);
                cmd.Parameters.AddWithValue("@nombreCliente", Cli.Nombre);
                cmd.Parameters.AddWithValue("@apellidoCliente", Cli.Apellido);
                cmd.Parameters.AddWithValue("@fechaRegistroCliente", Cli.Fecha_Registro);
                cmd.Parameters.AddWithValue("@correoCliente", Cli.Correo);
                cmd.Parameters.AddWithValue("@telefonoCliente", Cli.Telefono);
                cmd.Parameters.AddWithValue("@estadoCliente", Cli.Estado);
                cmd.Parameters.AddWithValue("@descripcionCliente", Cli.Descripcion);
                cmd.Parameters.AddWithValue("@lugarNaCliente", Cli.Pais);
                cmd.Parameters.AddWithValue("@estadocivil", Cli.EstadoCivil);
                cmd.Parameters.AddWithValue("@genero", Cli.Genero);
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
        public Boolean DeshabilitarCliente(entUsuario Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@estadoCliente", Cli.Estado);
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
        public Boolean EditarCliente(entUsuario Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@dniCliente", Cli.DNI);
                cmd.Parameters.AddWithValue("@nombreCliente", Cli.Nombre);
                cmd.Parameters.AddWithValue("@apellidoCliente", Cli.Apellido);
                cmd.Parameters.AddWithValue("@fechaRegistroCliente", Cli.Fecha_Registro);
                cmd.Parameters.AddWithValue("@correoCliente", Cli.Correo);
                cmd.Parameters.AddWithValue("@telefonoCliente", Cli.Telefono);
                cmd.Parameters.AddWithValue("@estadoCliente", Cli.Estado);
                cmd.Parameters.AddWithValue("@descripcionCliente", Cli.Descripcion);
                cmd.Parameters.AddWithValue("@lugarNaCliente", Cli.Pais);
                cmd.Parameters.AddWithValue("@estadocivil", Cli.EstadoCivil);
                cmd.Parameters.AddWithValue("@genero", Cli.Genero);
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
        public entUsuario BuscarCliente(int clienteID)
        {
            SqlCommand cmd = null;
            entUsuario cliente = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente = new entUsuario();
                    cliente.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cliente.DNI = dr["dniCliente"].ToString();
                    cliente.Nombre = dr["nombreCliente"].ToString();
                    cliente.Apellido = dr["apellidoCliente"].ToString();
                    cliente.Descripcion = dr["descripcionCliente"].ToString();
                    cliente.Fecha_Registro = Convert.ToDateTime(dr["fechaRegistroCliente"]);
                    cliente.Correo = dr["correoCliente"].ToString();
                    cliente.Telefono = dr["telefonoCliente"].ToString();
                    cliente.Estado = Convert.ToBoolean(dr["estadoCliente"]);
                    cliente.Pais = dr["lugarNaCliente"].ToString();
                    cliente.EstadoCivil = dr["estadocivil"].ToString();
                    cliente.Genero = dr["genero"].ToString();
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
            return cliente;
        }
    }
}