using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketApplication.Models;
using TicketApplication.Repository;

namespace TicketApplication.Controllers;

public class HomeController : Controller
{
    private readonly ITicketRepository repository;
    public HomeController(ITicketRepository repo)
    {
        repository = repo;
    }

    //private readonly ILogger<HomeController> _logger;

   // public HomeController(ILogger<HomeController> logger)
    //{
       // _logger = logger;
    //}

    public IActionResult Index()
    {
        var tickets = repository.GetAll();
        return View(tickets);
    }

    public IActionResult Add()
    {
        ViewBag.Statuses = new SelectList(repository.GetStatuses(), "Id", "Name");
        return View();
    }
    [HttpPost]
    public IActionResult Add(Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            repository.Add(ticket);
            return RedirectToAction("Index");
        }
        ViewBag.Statuses = new SelectList(repository.GetStatuses(), "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    public IActionResult Edit(int id)
    {
        var ticket = repository.GetById(id);
        if (ticket == null)
        {
            return NotFound();
        }
        ViewBag.Statuses = new SelectList(repository.GetStatuses(), "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    [HttpPost]
    public IActionResult Edit(int id,Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            repository.Update(ticket);
            return RedirectToAction("Index");
        }
        ViewBag.Statuses = new SelectList(repository.GetStatuses(), "Id", "Name", ticket.TicketStatusId);
        return View(ticket);
    }
    public IActionResult Delete(int id)
    {
        var ticket = repository.GetById(id);
        if (ticket == null)
        {
            return NotFound();
        }
        return View(ticket);
    }
    [HttpPost]
    public IActionResult Delete(Ticket ticket)
    {
        repository.Delete(ticket.Id);
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
