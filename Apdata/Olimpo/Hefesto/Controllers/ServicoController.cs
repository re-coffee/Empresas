using Microsoft.AspNetCore.Mvc;

namespace Hefesto.Controllers
{
    public class ServicoController : Controller
    {
        public IActionResult Index()
        {
            return View(new IndexView("Servico"));
        }
    }
}
