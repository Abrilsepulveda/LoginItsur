
using LoginItsur.Models;
using System.Data.SqlClient;
using System.Data;
using LoginItsur.services;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace LoginItsur.Logica
{
    public class Usuarios
    {
        public Usuarios EncontrarUsuario(string correo, string clave)
        {

            Usuarios objeto = new Usuarios();

       

            string query = "select UserId, Cotrasenia, Administrador, CambiarContrasenia from Usuarios where UserID = @puserID and Contrasenia = @pcontrasenia";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@puserID", UserID);
            cmd.Parameters.AddWithValue("@pcotrasenia", Cotrasenia);
            cmd ComandType = ComandType.Text;

            ConexionDB.Open();

            using(SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    objeto = new Usuarios()
                    {
                        UserID = dr["Usuario"].ToString(),
                        Cotrasenia = dr["Contraseña"].ToString(),
                        Administrador = dr["Administrador"].ToString(),
                        CambiarContrasenia = dr["Cambiar Contraseña"],

                    }
                }
            }

            return objeto;
        }
    }
}
