using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(string game = "ALL", string category = "ALL")
        {
            
            var countries = context.OlympicSports.AsQueryable();

            
            if (game != "ALL") countries = countries.Where(c => c.Game == game);
            if (category != "ALL") countries = countries.Where(c => c.Category == category);

            
            ViewBag.Games = context.OlympicSports.Select(c => c.Game).Distinct().ToList();
            ViewBag.Categories = context.OlympicSports.Select(c => c.Category).Distinct().ToList();
            ViewBag.SelectedGame = game;
            ViewBag.SelectedCategory = category;

            countries = countries.OrderBy(c => c.Name);

            var countryList = countries.ToList();

            return View(countryList);
        }
    }
}
