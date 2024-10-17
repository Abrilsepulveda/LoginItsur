
using LoginItsur.Models;
using System.Data.SqlClient;
using System.Data;
using LoginItsur.services;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace LoginItsur.Logica
{
    public class LO_Usuario
    {
        public Usuarios EncontrarUsuario(string correo, string clave)
        {

            Usuarios objeto = new Usuarios();

            using (SqlConnection conexion = new SqlConnection("Data source=(mercurio) ; Initial Catalog=Db_ITsur_CSharp; "))

            string query = "select UserId, Contrasenia, Administrador, CambiarContrasenia from Usuarios where UserID = @puserID and Contrasenia = @pcontrasenia";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@puserID", UserID);
            cmd.Parameters.AddWithValue("@pcontrasenia", Contrasenia);
            cmd ComandType = ComandType.Text;

            ConexionDB.Open();

            using(SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    objeto = new Usuarios()
                    {
                        UserID = dr["Usuario"].ToString(),
                        Contrasenia = dr["Contraseña"].ToString(),
                        Administrador = dr["Administrador"].ToString(),
                        CambiarContrasenia = dr["Cambiar Contraseña"],

                    }
                }
            }

            return objeto;
        }
    }
}
