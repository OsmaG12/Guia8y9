using Microsoft.AspNetCore.Mvc;

namespace Guia_9.Controllers
{
    public class VistarRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult bloqueMultiple()
        {
            return View();
        }

        public ActionResult condiciones() 
        {
            return View();
        }

        public ActionResult bucles () 
        {
            return View();
        }

        public ActionResult guia8()
        {
            return View();
        }
    }
}
