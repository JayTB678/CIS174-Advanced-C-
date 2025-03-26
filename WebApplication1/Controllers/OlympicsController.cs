using DataTransferApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OlympicsController : Controller
    {
        private readonly SportsContext context;

        public OlympicsController(SportsContext cxt)
        {
            context = cxt;
        }
        public IActionResult Index(OlympicsViewModel model)
        {
            var countries = context.OlympicSports.AsQueryable();

            if (model.SelectedGame != "ALL")
                countries = countries.Where(c => c.Game == model.SelectedGame);

            if (model.SelectedCategory != "ALL")
                countries = countries.Where(c => c.Category == model.SelectedCategory);

            model.Games = context.OlympicSports.Select(c => c.Game).Distinct().ToList();

            model.Categories = context.OlympicSports.Select(c => c.Category).Distinct().ToList();

            model.Countries = countries.OrderBy(c => c.Name).ToList();

            return View(model);
        }
        public IActionResult Details(int id)
        {
            var sport = context.OlympicSports.FirstOrDefault(s => s.Id == id);
            if (sport == null) return NotFound();
            return View(sport);
        }
        public IActionResult Favorites(int id)
        {
            var sport = context.OlympicSports.FirstOrDefault(s => s.Id == id);
            if (sport == null) return NotFound();

            List<OlympicSport> favorites = HttpContext.Session.GetObject<List<OlympicSport>>("Favorites") ?? new List<OlympicSport>();

            if (!favorites.Any(f => f.Id == id))
                favorites.Add(sport);

            HttpContext.Session.SetObject("Favorites", favorites);
            return RedirectToAction("Index");
        }
    }
}
