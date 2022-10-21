using Microsoft.AspNetCore.Mvc;

namespace TP04.Controllers
{
    public class test : Controller
    {
        
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

    }
}

