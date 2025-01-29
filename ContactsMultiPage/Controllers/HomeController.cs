using System.Diagnostics;
using ContactsMultiPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsMultiPage.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}

        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(contacts);
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            ViewBag.Action = "Add";
            return View("Add", new Contact());
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if(ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else
            {
                ViewBag.Action = (contact.ContactId == 0);
                return View(contact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
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
