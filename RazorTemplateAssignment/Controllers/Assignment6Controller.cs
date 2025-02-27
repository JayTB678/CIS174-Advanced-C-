using Microsoft.AspNetCore.Mvc;
using RazorTemplateAssignment.Models;

namespace RazorTemplateAssignment.Controllers
{
    public class Assignment6Controller : Controller
    {
        public IActionResult Index(int accessLevel = 1)
        {
            var students = new List<Student> 
            { 
                new Student {FirstName = "Jared", LastName = "Brannen", Grade = "A"},
                new Student {FirstName = "Lebron", LastName = "James", Grade = "B"},
                new Student {FirstName = "Robert", LastName = "Downey Jr.", Grade = "F"}
            };

            var studentViewModel = new StudentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View(studentViewModel);
        }
    }
}
