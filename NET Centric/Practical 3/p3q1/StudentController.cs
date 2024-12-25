using Microsoft.AspNetCore.Mvc;
using Q1.Models;
using System.Collections.Generic;

namespace Q1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Bimochan", Age = 22, Gender = "Male", Department = "CS" },
                new Student { Id = 2, Name = "Sita", Age = 23, Gender = "Female", Department = "IT" },
                new Student { Id = 3, Name = "Ram", Age = 24, Gender = "Male", Department = "EC" }
            };

            return View(students);
        }
    }
}
