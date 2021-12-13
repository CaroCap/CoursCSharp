using DBSlideDataContext.DTO;
using DBSlideDataContext.Services;
using ExerciceStudentMVCOK.Handlers;
using ExerciceStudentMVCOK.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciceStudentMVCOK.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository<Student> service;
        public StudentController(IRepository<Student> service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            IEnumerable<StudentListItem> students = service.Get().Select(s => s.ToListItem());
            return View(students);
        }
    }
}
