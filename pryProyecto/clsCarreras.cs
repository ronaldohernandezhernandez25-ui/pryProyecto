using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    internal class clsCarreras
    {
     private MySqlDataAdapter consulta;
     private DataTable tabla;

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            ClaseConexion conexionDB = new ClaseConexion();
            var conexion = conexionDB.AbrirConexion();
            string sql = "SELECT * FROM tblCarreras;";
            consulta = new MySqlDataAdapter(sql, conexion);
            consulta.Fill(tabla);
            return tabla;
        }
    }
}
