using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ResponsiveWebAppBrannen.Models;

namespace ResponsiveWebAppBrannen.Controllers
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
            ViewBag.GA = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(BirthAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.GA = model.ageThisYear();
            }
            else
            {
                ViewBag.GA = "";
            }

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
