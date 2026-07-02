using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryProyecto
{
    internal class clsAlumnos
    {
        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;

        private int idTutor;
        private int idCarrera;
        private int idUsuario;

        private string nombreUsuario;
        private string password;
        private string perfil;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                ClaseConexion conexionDB = new ClaseConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreALUMNO AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, "+ // <-- SE AGREGA EL PASSWORD
                                 "U.vchperfil, "+ //<-- SE AGREGA EL PERFIL
                                 "A.direccion, A.telefono, A.correo, " +
                                 "A.promedioBachillerato, A.foto, " +
                                 "A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";

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
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //valuemember es el idCarrera y el DisplayMember es el nombre carrera
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de tutores: " + ex.Message);
            }
            return tabla;
        }

        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreALUMNO AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, "+ // <-- SE AGREGA EL PASSWORD
                                 "U.vchperfil, "+ //<-- SE AGREGA EL PERFIL
                                 "A.direccion, A.telefono, A.correo, " +
                                 "A.promedioBachillerato, A.foto, " +
                                 "A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE A.matricula LIKE @matricula;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        // Asegurar coincidencia exacta del nombre del parámetro
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
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
