using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }
    }
}
