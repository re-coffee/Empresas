using Microsoft.AspNetCore.Mvc;

namespace Hefesto.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
