using DataTransferApplication.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace DataTransferApplication.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            var favorites = HttpContext.Session.GetObject<List<OlympicSport>>("Favorites") ?? new List<OlympicSport>();
            return View(favorites);
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("Favorites");
            return RedirectToAction("Index");
        }
    }
}
