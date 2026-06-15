using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public static bool EsAdministrador { get => esAdministrador; private set => esAdministrador = value; }
        public static bool EsDocente { get => esDocente; private set => esDocente = value; }

        //atributo estatica
        private static string perfil;
        private static bool esAdministrador;
        private static bool esDocente;

        public void AsignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":

                    break;
                case "Docente":

                    break;
            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                ClaseConexion conexionBD = new ClaseConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT perfil FROM tblUsuarios " +
                        "WHERE nombreUsuario = @usuario AND password = @password";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                MessageBox.Show("Tu perfil es: " + perfil + " Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o Contraseña incorrectos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}

