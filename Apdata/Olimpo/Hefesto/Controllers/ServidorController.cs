using Microsoft.AspNetCore.Mvc;

namespace Hefesto.Controllers
{
    public class ServidorController : Controller
    {
        public IActionResult Index()
        {
            return View(new IndexView("Servidor"));
        }
    }
}
