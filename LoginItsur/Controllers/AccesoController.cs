using Microsoft.AspNetCore.Mvc;
using LoginItsur.Models.
using LoginItsur.Logica;

namespace LoginItsur.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserId, string Cotrasenia) {

            Usuarios objeto = new LO_Usuario().EncontrarUsuario(UserId, Cotrasenia);

            return View();
    }
}
