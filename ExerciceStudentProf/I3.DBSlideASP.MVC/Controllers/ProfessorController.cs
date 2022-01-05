using DBSlideDataContext.DTO;
using DBSlideDataContext.Services;
using I3.DBSlideASP.MVC.Handlers;
using I3.DBSlideASP.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IRepository<Professor> _service;
        public ProfessorController(IRepository<Professor> service)
        {
            this._service = service;
        }

        // GET: ProfessorController
        //SIMPLE
        //public ActionResult Index()
        //{
        //    IEnumerable<ProfessorListItem> model = this._service.Get().Select(p => p.ToListItem());
        //    return View(model);
        //}

        // ORDRE
        // Ajouter dans l'url 
        // ?primarySort=section ou ?primarySort=name ou ?primarySort=surname
        //public ActionResult Index(string primarySort)
        //{
        //    IEnumerable<ProfessorListItem> model = this._service.Get().Select(p => p.ToListItem());
        //    if (primarySort is null)
        //    {
        //        return View(model);
        //    }
        //    switch (primarySort.ToLower())
        //    {
        //        case "nom": model = model.OrderBy(p => p.Professor_Name);
        //            break;
        //        case "prenom": model = model.OrderBy(m => m.Professor_Surname);
        //            break;
        //        case "section": model = model.OrderBy(m => m.Section_ID);
        //            break;
        //    }
        //    return View(model);
        //}

        // /professor?sorted=true
        public ActionResult Index(bool? sorted)
        {
            IEnumerable<ProfessorListItem> model = this._service.Get().Select(p => p.ToListItem());
            if ((sorted is null) || sorted == true)
            {
                model = model.OrderBy(p => p.Professor_Name).ThenBy(p => p.Professor_Surname);
            }
            return View(model);
        }

        // GET: ProfessorController/Details/5
        public ActionResult Details(int id)
        {
            ProfessorDetails model = this._service.Get(id).ToDetails();
            return View(model);
        }

        // GET: ProfessorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfessorCreateForm collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                //if (collection.Prenom != "Sam") throw new ArgumentException("Le prénom n'est pas Sam");
                Professor result = new Professor()
                {
                    Professor_Name = collection.Professor_Name,
                    Professor_Surname = collection.Professor_Surname,
                    Section_ID = collection.Section_ID,
                    Professor_Office = collection.Professor_Office,
                    Professor_Email = collection.Professor_Email,
                    Professor_Wage = collection.Professor_Wage,
                    Professor_HireDate = collection.Professor_HireDate
                };
                this._service.Insert(result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View(collection);
            }
        }

        // GET: ProfessorController/Edit/5
        public ActionResult Edit(int id)
        {
            ProfessorEditForm model = this._service.Get(id).ToEditForm();
            return View(model);
        }

        // POST: ProfessorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProfessorEditForm collection)
        {
            Professor result = this._service.Get(id);
            try
            {
                if (result is null) throw new Exception("Pas de professeur avec cet identifiant");
                if (!(ModelState.IsValid)) throw new Exception();
                //Les tests de validations étant correct, on mets à jour le prof 'result' avant l'envois dans la DB
                result.Professor_Office = collection.Professor_Office;
                result.Professor_Wage = collection.Professor_Wage;
                this._service.Update(id, result);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                ViewBag.Error = e.Message;
                if (result is null) return RedirectToAction(nameof(Index));
                return View(result.ToEditForm());
            }
        }

        // GET: ProfessorController/Delete/5
        public ActionResult Delete(int id)
        {
            ProfessorDeleteForm model = this._service.Get(id).ToDeleteForm();
            return View(model);
        }

        // POST: ProfessorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProfessorDeleteForm collection)
        {
            Professor result = this._service.Get(id);
            try
            {
                if (result is null) throw new Exception("Pas de professeur avec cet identifiant.");
                if (!ModelState.IsValid) throw new Exception();
                if (!collection.Validate) throw new Exception("Action non validée...");
                this._service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
