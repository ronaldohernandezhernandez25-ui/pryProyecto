using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    internal class clsTutores
    {
        private string nombreComp;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;
        private int idTutor; //este atributo es para referencia en update y delete
        //Usar un adaptador
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string NombreComp { get => nombreComp; set => nombreComp = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }



        

        //Metodo para consultar por coincidencias
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, " + "parentesco AS Parentesco, direccion AS Direccion, " + "telefono AS Telefono, correo AS Correo " + "FROM tbltutores WHERE nombreTutor LIKE @Tutor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombreTutor", "%" + nombreComp + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
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
                            string sqlN = "insert into tbltutores  (nombreTutor,parentesco, direccion,telefono,correo) values(@nombreTutor, @parentesco,@direccion,@telefono,@correo)";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreComp);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

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
                            string sqlA = "UPDATE tbltutores C SET C.nombreTutor = @nombreTutor, C.parentesco = @parentesco, C.direccion = @direccion, C.telefono = @telefono, C.correo = @correo WHERE C.idTutor = @idTutor";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {

                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreComp);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

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

       
    }
}

