
using LoginItsur.Models;
using System.Data.SqlClient;
using System.Data;

namespace LoginItsur.Logica
{
    public class LO_Usuario
    {
        public Usuarios EncontrarUsuario(string correo, string clave)
        {

            Usuarios objeto = new Usuarios();

            using(SqlConnection conexion = new SqlConnection("Data source=(mercurio) ; Initial Catalog=Db_ITsur_CSharp; "))

            return objeto;
        }
    }
}
