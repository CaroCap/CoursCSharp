using DBSlideDataContext.DTO;
using DBSlideDataContext.Services;
using ExerciceStudentMVCOK.Handlers;
using ExerciceStudentMVCOK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            // Pour compter les étudiants, on peut utiliser ViewBag et ViewData (mêmes fonctionnalités mais autre manière de mettre infos) qui font partie des propriétés du Controller et qui permettent de préparer le nombre qu'on injectera dan la view mais pas utile dans ce cas-ci
            // .Count() = LinQ à ajouter dans les using !
            //ViewBag.number = students.Count();
            //ViewData["number"] = students.Count();
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
            // Pour ajouter les options dans la view
            StudentAddForm model = new StudentAddForm();
            // On va utiliser linQ pour aller récupérer la Section ID de notre student = .Select
            // On va utiliser LinQ pour n'avoir qu'une seule fois chaque élément = .Distinct
            // On peut ajouter ToList() ou ToArray() si besoin mais nous on veut IEnumerable donc pas besoin
            // Section_ID vient du DTO
            model.Sections_IDs = service.Get().Select(s=>s.Section_ID).Distinct().OrderBy(s=>s);
            model.Courses_IDs = service.Get().Select(s=>s.Course_ID).Distinct().OrderBy(c => c);
            return View(model);
        }

        [HttpPost]
        public IActionResult AddStudent(StudentAddForm newStudentForm)
        {
            ValidateYearsOld(newStudentForm, ModelState, 18);
            if (!ModelState.IsValid)
            {
                newStudentForm.Sections_IDs = service.Get().Select(s => s.Section_ID).Distinct().OrderBy(s => s);
                newStudentForm.Courses_IDs = service.Get().Select(s => s.Course_ID).Distinct().OrderBy(c => c);
                return View(newStudentForm);
            }
            service.Insert(newStudentForm.ToDTO());
            return RedirectToAction("Index");
        }

        //IFormCollection renvoie du string donc prob pour les int et autre donc c'est mieux d'utiliser notre propre modèle
        //[HttpPost]
        //public IActionResult AddStudent(IFormCollection form)
        //{
        //    //ValidateLoginForm(form, ModelState);
        //    if (!ModelState.IsValid) return View();
        //    return RedirectToAction("Index", "Home");
        //}


        // Création d'une méthode pour valider la date de naissance pour vérifier qu'il soit majeur
        // 1e critère = le modèle; 2e élément = l'état de ma page; 3e élément = l'âge (majorité peut changer selno pays)
        private static void ValidateYearsOld(StudentAddForm form, ModelStateDictionary modelState, int yearsOld)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - form.DateNaissance.Year;
            if (age < yearsOld)
                modelState.AddModelError(nameof(form.DateNaissance), $"Vous n'avez pas encore {yearsOld} ans...");
        }
    }
}
