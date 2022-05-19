using Microsoft.AspNetCore.Mvc;

namespace lexical_analyzer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
