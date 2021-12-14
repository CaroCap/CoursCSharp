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

        public IActionResult Details(int id)
        {
            StudentDetails student = service.Get(id).ToDetails();
            if(student is not null) return View(student);
            return RedirectToAction("Index");
        }

        public IActionResult AddStudent()
        {
            return View("AddStudent");
        }
    }
}
