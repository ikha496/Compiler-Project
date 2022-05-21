using Microsoft.AspNetCore.Mvc;
using lexical_analyzer.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;
using System.IO;


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

        public IActionResult Type() 
        {
            FileContent read = new FileContent();
            ViewBag.result = new string[] { " " };
            return View(read);
        }

        [HttpPost]
        public IActionResult Type(FileContent readFile)
        {
            Scanner scanner = new Scanner();
            scanner.fileContent = readFile.fileContent;
            scanner.initScanner();
            scanner.Scan();
            if (scanner.compilerManager.scannerMessages != null) 
            {
                ViewBag.result = scanner.compilerManager.scannerMessages;
            }
            else
            {
                ViewBag.result = new string[] {" "};
            }
            return View(readFile);
        }

        /*[HttpPost]
        public IActionResult ParsingFile(File file) {
            ReadFile read = new ReadFile();
            System.IO.Path.GetDirectoryName(file);
            read.FileContent = System.IO.File.ReadAllText(file);

            return RedirectToAction("Type","Home");
        }*/


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewer { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
