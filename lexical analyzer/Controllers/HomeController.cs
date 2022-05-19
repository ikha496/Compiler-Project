using Microsoft.AspNetCore.Mvc;
using lexical_analyzer.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;

namespace lexical_analyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ReadFile readFile)
        {
            Scanner scanner = new Scanner();
            scanner.codeFile = readFile.FileContent;
            scanner.initScanner();
            scanner.Scan();
            return View(readFile);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
