using Microsoft.AspNetCore.Mvc;
using LoginItsur.Models;

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

            Usuarios usuario = new Usuarios().EncontrarUsuario(UserId, Cotrasenia);
            if (usuario != null)
            {

            }

            return View();
    }
}
