using Microsoft.AspNetCore.Mvc;

namespace Hefesto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View(new IndexView("Cliente"));
        }
    }
}
