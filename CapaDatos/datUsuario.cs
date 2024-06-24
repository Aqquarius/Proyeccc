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
        public string connectionString = "Server=Danysex\\SQLEXPRESS;Database=Farmacia;Integrated Security=True;";

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
                cmd = new SqlCommand("splistaUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario Usu = new entUsuario();
                    Usu.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Usu.dni = dr["dni"].ToString();
                    Usu.nombre = dr["nombre"].ToString();
                    Usu.apellido = dr["apellido"].ToString();
                    Usu.fecha_registro = Convert.ToDateTime(dr["fecha_registro"]);
                    Usu.correo = dr["correo"].ToString();
                    Usu.telefono = dr["telefono"].ToString();
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
    }
}
