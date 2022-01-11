using Demo.CinemaProject.ASP.Handlers;
using Demo.CinemaProject.ASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SessionManager session; // Pour pouvoir utiliser la session => Ajouter dans le constructeur

        public HomeController(ILogger<HomeController> logger, SessionManager session)
        {
            _logger = logger;
            this.session = session;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index","Cinema"); // On redirige pour que quand on va sur le home on soit direct rediriger vers Cinema/Index
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

        // POSSIBILITE DE FAIRE DES SESSIONS
        public IActionResult Session()
        {
            //HttpContext.Session.Set("MonTableauDeByte", new byte[0]);
            //HttpContext.Session.SetString("ValeurString", "toto");
            //HttpContext.Session.SetInt32("ValeurInt", 35);

            // On va utiliser à la place le Session Manager pour pouvoir plus facilement mettre des données plus complexes et plus nombreuses
            this.session.MonTableauDeByte = new byte[0];
            this.session.ValeurString = "toto";
            this.session.ValeurInt = 42;
            return View();
        }

        public IActionResult SessionCinema()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionCinema(CinemaListItem collection)
        {
            if (collection is null) return View(); // Si pas de nouveau cinema favori, on retourne à notre vue initiale
            session.AddCinema(collection); // Sinon, on ajoute le cinéma favori à la liste
            return View(); 
        }

        // POUR LA SESSION USER
        public IActionResult Login()
        {
            if (session.IsConnected) return RedirectToAction("Index", "Home");
            return View();
        }
    }
}
