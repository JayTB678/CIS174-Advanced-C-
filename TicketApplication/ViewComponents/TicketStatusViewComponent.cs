using Microsoft.AspNetCore.Mvc;
namespace TicketApplication.ViewComponents
{
    public class TicketStatusViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string statusName)
        {
            return View("Default", statusName);
        }
    }
}
