using Microsoft.AspNetCore.Mvc;

namespace TP04.Controllers
{
    public class CadeteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCadete()
        {
            return View();
        }

        public IActionResult DelCadete()
        {
            return View();
        }
    }
}
