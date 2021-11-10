using Microsoft.AspNetCore.Mvc;

namespace Escuela.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
