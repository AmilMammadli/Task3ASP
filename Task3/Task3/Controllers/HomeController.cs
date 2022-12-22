using Microsoft.AspNetCore.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
