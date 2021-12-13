using DBSlideDataContext.DTO;
using DBSlideDataContext.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository<Student> service;

        public List<Student> Movies = new List<Student>(
            new Student [] {
        new Movie() { Id = 1 , Title = "Jurassic Park", Subtitle = null,  Minutes = 90, RealeaseDate = new DateTime(1993,6,21)},
            new Movie() { Id = 2, Title = "Matrix", Subtitle = null, Minutes = 90, RealeaseDate = new DateTime(1999, 6, 21) }, new Movie() { Id = 3, Title = "Matrix", Subtitle = "Reloaded", Minutes = 90, RealeaseDate = new DateTime(1993, 6, 21) }
        });

        public StudentController(IRepository<Student> service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(this.Student);
        }
    }
}
