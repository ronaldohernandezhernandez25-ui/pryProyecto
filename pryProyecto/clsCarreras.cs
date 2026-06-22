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
        private string nombreCarrera;

        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                ClaseConexion conexionDB = new ClaseConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras;;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripción FROM tblcarreras WHERE nombreCarrera LIKE @Carrera;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%"+nombreCarrera+"%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos" + ex.Message);
            }

            return tabla;
        }
    }
}
