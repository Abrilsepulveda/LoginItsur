using LoginItsur.services;
using System.Data.SqlClient;

namespace LoginItsur.Models
{
    public class LoginItsur
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
                                NroOrdenTrabajo = reader.GetDecimal(reader.GetOrdinal("NroOrdenTrabajo")),
                                Cliente = reader.GetInt32(reader.GetOrdinal("Cliente")),
                                Sistema = reader.GetInt32(reader.GetOrdinal("Sistema")),
                                Asunto = reader.GetString(reader.GetOrdinal("Asunto")),
                                FechaSolicitud = reader.GetDateTime(reader.GetOrdinal("FechaSolicitud")),
                                UserIDSolicitante = reader.GetString(reader.GetOrdinal("UserIDSolicitante"))
                            };
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
 
