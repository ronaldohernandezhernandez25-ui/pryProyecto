using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryProyecto
{
    internal class ClaseConexion
    {
        private string host = "189.240.192.140";
        private string bd = "bdescuelagbequipo6";
        private string usuario = "gbEquipo6";
        private string contraseña = "grupo6";
        private string puerto = "3306";

        private string cadenaConexion => $"server={host}; database={bd}; user={usuario}; password={contraseña}; port={puerto};";

        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectar la base de datos" + ex.Message, ex);
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos" + ex.Message, ex);
            }
        }
    }
}
