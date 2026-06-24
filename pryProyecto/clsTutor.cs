using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    internal class clsTutor
    {
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string email;
        private int idTutor; //este atributo es para referencia en update y delete
        //Usar un adaptador
        private MySqlDataAdapter consulta;
        //usamos comandpara insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;


        //propiedad para el atributo nombre tutor
        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }



        //metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Dirección, telefono AS Número de telefono, correo AS Correo electrónico FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta

                }//liberar la conexion
            }
            catch (Exception ex)
            {

                throw new Exception("error en la conexion " + ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencias
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave,nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Dirección, telefono AS Número de telefono, correo AS Correo electrónico\r\nFROM tbltutores WHERE nombreTutor LIKE @Tutor; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@Tutor", "%" + nombreTutor + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberara el adaptador
                    }//Liberar la consulta
                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos" + ex.Message);
            }
            return tabla;
        }


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
                        case 0:
                            //registro nuevo
                            string sqlN = "insert into tbltutores  (nombreTutor,parentesco, direccion,telefono,correo) values(@nombreTutor, @parentesco,@direccion,@telefono,@email)";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("email", email);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardó correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los  datos....";
                                }
                            }
                            break;
                        case 1:
                            string sqlA = "UPDATE tbltutores C SET C.nombreTutor = @nombreTutor, C.parentesco = @parentesco, C.direccion = @direccion, C.telefono = @telefono, C.correo = @email  WHERE C.idTutor = @idTutor";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {

                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("email", email);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardó correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los  datos....";
                                }
                            }
                            break;
                    }

                }
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
                    string sql = "DELETE FROM tbltutores WHERE idTutor = @idTutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    } //liberar la eliminacion
                } //liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}

