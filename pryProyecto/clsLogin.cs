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
                    esAdministrador = true;
                    esDocente = false;
                    break;
                case "Docente":
                    esDocente = true;
                    esAdministrador = false;
                    break;
                default:
                    esAdministrador=false;
                    esDocente = false;
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
                                AsignarPermisos();
                                if(!esAdministrador && !esDocente)
                                {
                                    throw new Exception($"El perfil {perfil} no tiene permisos para acceder");
                                }
                                MessageBox.Show("Tu perfil es:"+perfil,"sistema");
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

