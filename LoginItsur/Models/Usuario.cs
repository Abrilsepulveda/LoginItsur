using System.Linq.Expressions;
using LoginItsur.services;
using System.Data.SqlClient;

namespace LoginItsur.Models
{
    public class Usuarios
    {
        public string UserID { get; set; }
        public string Cotrasenia { get; set; }
        public string Administrador { get; set; }

        public Usuarios EncontrarUsuario(string UserID, string Cotrasenia)
        {

            Usuarios usuario = new Usuarios();

            string query = "Select UserID, Cotrasenia, Administrador from Usuarios WHERE UserID = @puserid and Cotrasenia = @pcotrasenia";
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.AbrirConexion();
            using (SqlCommand comand = new SqlCommand(query, conexionDB.con))
            {
                comand.Parameters.AddWithValue("@puserid", UserID);
                comand.Parameters.AddWithValue("@pcotrasenia", Cotrasenia);
                try
                {
                    using (SqlDataReader reader = comand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario = new Usuarios()
                            {
                                UserID = reader["UserID"].ToString(),
                                Cotrasenia = reader["Cotrasenia"].ToString(),
                                Administrador = reader["Administrador"].ToString(),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return usuario;
        }
    }
}
       
