using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketApplication.Models;

namespace TicketApplication.Controllers;

public class HomeController : Controller
{
    private readonly TicketContext context;
    public HomeController(TicketContext ctx)
    {
        context = ctx;
    }

    //private readonly ILogger<HomeController> _logger;

   // public HomeController(ILogger<HomeController> logger)
    //{
       // _logger = logger;
    //}

    public IActionResult Index()
    {
        var tickets = context.Tickets.Include(t => t.Status).ToList();
        return View(tickets);
    }

    public IActionResult Add()
    {
        ViewBag.Statuses = new SelectList(context.TicketStatuses, "Id", "Name");
        return View();
    }
    [HttpPost]
    public IActionResult Add(Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        ViewBag.Statuses = new SelectList(context.TicketStatuses, "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    public IActionResult Edit(int id)
    {
        var ticket = context.Tickets.Include(t => t.Status).FirstOrDefault(t => t.Id == id);
        if (ticket == null)
        {
            return NotFound();
        }
        ViewBag.Statuses = new SelectList(context.TicketStatuses, "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    [HttpPost]
    public IActionResult Edit(int id,Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            context.Update(ticket);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        ViewBag.Statuses = new SelectList(context.TicketStatuses, "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    public IActionResult Delete(int id)
    {
        var ticket = context.Tickets.Include(t => t.Status).FirstOrDefault(t => t.Id == id);
        if (ticket == null)
        {
            return NotFound();
        }
        return View(ticket);
    }
    [HttpPost]
    public IActionResult Delete(Ticket ticket)
    {
        context.Tickets.Remove(ticket);
        context.SaveChanges();
        return RedirectToAction("Index");
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
