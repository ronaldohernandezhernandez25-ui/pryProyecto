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
        private string descripcion;
        private int idCarrera;//Este atributo es para referencia para update y delete

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                ClaseConexion conexionDB = new ClaseConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras;";
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
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
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

        //Metodo para actualizar
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0://Insertar new
                            string sqlN = "INSERT INTO tblcarreras(nombreCarrera,descripcion) VALUES(@nombreCarrera,@descripcion);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "No se guardaron los datos....";
                                }

                            }//libera la operacion de insercion
                            break;
                        case 1://Actualizar old
                            string sqlA = "UPDATE tblcarreras C SET C.nombreCarrera = @nombreCarrera, C.descripcion = @descripcion WHERE C.idCarrera = idCarrera;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {

                                comando.Parameters.AddWithValue("idCarrera", idCarrera);
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "No se guardaron los datos....";
                                }

                            }//libera la operacion de actualizacion
                            break;
                    }

                }//libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {

                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblcarreras C WHERE C.idCarrera = @idCarrera;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//libera la operacion de eliminacion
                }//libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}
