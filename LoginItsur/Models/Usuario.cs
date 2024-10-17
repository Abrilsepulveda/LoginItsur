using LoginItsur.services;
using System.Data.SqlClient;

namespace LoginItsur.Models
{
    public class Usuarios
    {
        public decimal UserID { get; set; }
        public int Cotrasenia { get; set; }
        public int Administrador { get; set; }
        public string CambiarContrasenia { get; set; }
       

        public static List<LoginItsur> ObtenerLista(string consulta)
        {

            List<LoginItsur> OrdenesTrabajo = new List<LoginItsur>();
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.AbrirConexion();
            using (SqlCommand command = new SqlCommand(consulta, conexionDB.con))

            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoginItsur Orden = new LoginItsur
                            {
                                UserID = reader.GetDecimal(reader.GetOrdinal("UserID")),
                                Cotrasenia = reader.GetInt32(reader.GetOrdinal("Cotrasenia")),
                                Administrador = reader.GetInt32(reader.GetOrdinal("Administrador")),
                                CambiarContrasenia = reader.GetString(reader.GetOrdinal("CambiarContrasenia")),
                            
                            Loginitsur.Add(Login);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hubo un error al ejecutar la consulta: " + e.ToString());
                }
            }
            return Loginitsur;
        }
    }

}
 
