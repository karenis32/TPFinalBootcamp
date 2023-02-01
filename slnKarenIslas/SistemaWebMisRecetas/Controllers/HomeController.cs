using Microsoft.AspNetCore.Mvc;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titulo = "Bienvenido a Tus Recetas";
            return View();
        }
    }
}
