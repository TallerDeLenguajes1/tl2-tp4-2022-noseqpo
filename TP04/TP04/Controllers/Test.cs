using Microsoft.AspNetCore.Mvc;

namespace TP04.Controllers
{
    public class test : Controller
    {
        
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

    }
}

