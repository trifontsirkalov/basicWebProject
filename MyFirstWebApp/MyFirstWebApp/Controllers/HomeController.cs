using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;
using System.Diagnostics;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            AboutViewModel vm = new AboutViewModel
            {
                Info = "The most amazing MVC framework in the world",
                Description = "Is ASP.NET FRAMEWORK developed by Microsoft............. :D"
            };

            return View(vm);
        }

        //var in the method should be named as in layout asp-route-id="10". In aour case id
        public IActionResult Numbers(int id)
        {
            var numInRange = id;
            ViewBag.numInRange = numInRange;
            
            return View();
        }

        [HttpPost]
        public IActionResult Numbers(string number)
        {
            int numInRange = int.Parse(number);
            ViewBag.numInRange = numInRange;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}