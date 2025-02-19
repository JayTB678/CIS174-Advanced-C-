using Microsoft.AspNetCore.Mvc;

namespace Ch04MovieListApp.Controllers
{
    [Route("Custom/[controller]/[action]")]
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the other controller.");
        }
    }
}
