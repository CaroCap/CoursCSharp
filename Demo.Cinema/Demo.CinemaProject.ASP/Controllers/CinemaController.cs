using Demo.CinemaProject.ASP.Handlers;
using Demo.CinemaProject.ASP.Models;
using Demo.CinemaProject.BLL.EntitiesBLL;
using Demo.CinemaProject.Common.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaRepository<CinemaBLL> _cinemaService;
        private readonly IDiffusionRepository<DiffusionBLL> _diffusionService;

        // Modifier le Startup pour que ça fonctionne
        public CinemaController(ICinemaRepository<CinemaBLL> cinemaService, IDiffusionRepository<DiffusionBLL> diffusionService)
        {
            _cinemaService = cinemaService;
            _diffusionService = diffusionService;
        }

        public IActionResult Index()
        {
            IEnumerable<CinemaListItem> model = _cinemaService.Get().Select(c => c.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            CinemaDetails model = _cinemaService.Get(id).ToDetails();
            model.Diffusions = _diffusionService.GetByCinemaId(id).Select(d => d.ToDetails());
            return View(model);
        }
    }
}
