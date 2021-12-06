using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace myFirstProject.Controllers
{
    public class ExercicesController : Controller
    {
        public static string name { get; set; }
            
        public IActionResult Index()
        {
            return View();
        }

        [Route("{id}/MultiplierPar2")]
        public IActionResult MultiplierParDeux(int id)
        {
            return Json(id * 2);
        }

        public IActionResult SaveName(string id)
        {
            ExercicesController.name = id;
            return Ok(id);
        }
        public IActionResult ShowName(int id)
        {
            List<string> resultat = new List<string>();

            for (int i = 0; i < id; i++)
            {
                resultat.Add(name);
            }
            return Json(resultat);
        }
    }
}
