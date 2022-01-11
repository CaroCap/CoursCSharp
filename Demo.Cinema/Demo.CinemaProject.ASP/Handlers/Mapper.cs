using Demo.CinemaProject.ASP.Models;
using Demo.CinemaProject.BLL.EntitiesBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Handlers
{
    // On ajoute static pour le Mapper et on mettra toutes les méthode de transformation en public static
    public static class Mapper
    {
        public static CinemaListItem ToListItem(this CinemaBLL entity)
        {
            if (entity == null) return null;
            return new CinemaListItem
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Ville = entity.Ville
            };
        }
        public static CinemaDetails ToDetails(this CinemaBLL entity)
        {
            if (entity == null) return null;
            return new CinemaDetails
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Ville = entity.Ville
            };
        }
        public static DiffusionDetails ToDetails(this DiffusionBLL entity)
        {
            if (entity == null) return null;
            return new DiffusionDetails
            {
                Id = entity.Id,
                DateDiffusion = entity.DateDiffusion,
                Film_id = entity.Film.Id,
                Cinema_id = entity.Cinema.Id,
                Titre = entity.Film.Titre
            };
        }
    }
}
