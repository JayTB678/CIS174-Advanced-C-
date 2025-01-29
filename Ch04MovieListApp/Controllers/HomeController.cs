using System.Diagnostics;
using Ch04MovieListApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Ch04MovieListApp.Controllers
{
    public class HomeController : Controller
    {
        

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}
        private MovieContext context {  get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = this.context.Genres.ToList();
            var movie = context.Movies.Include(a => a.Genre).Where(m => m.MovieId == id).FirstOrDefault();
            return View("Edit", new Movie());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = this.context.Genres.ToList();
            var movie = context.Movies.Include(a => a.Genre).Where(m => m.MovieId == id).FirstOrDefault();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                    context.Movies.Add(movie);
                else
                    context.Movies.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Genres = this.context.Genres.ToList();
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Genres = this.context.Genres.ToList();
            var movie = context.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        //public IActionResult Privacy()
        //{
        //return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
