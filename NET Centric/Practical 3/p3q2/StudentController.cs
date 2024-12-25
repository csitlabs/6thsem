using Microsoft.AspNetCore.Mvc;
using Q2.Models;
using System.Collections.Generic;

namespace Q2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Bimochan", Department = "CS" },
                new Student { Id = 2, Name = "Sita", Department = "IT" },
                new Student { Id = 3, Name = "Ram", Department = "EC" }
            };

            return View(students);
        }
    }
}
