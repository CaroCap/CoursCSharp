// On peut utiliser des alias pour nous faciliter le nom ==> using NomAlias = chemin de l'alias;
using Demo.CinemaProject.BLL.EntitiesBLL;
using D = Demo.CinemaProject.DAL.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.CinemaProject.BLL.Handlers
{
    // Mettre la classe en Public et Static
    public static class Mapper
    {
        // Transformer les Cinemas de mon DAL en Cinema de mon BLL
        public static CinemaBLL ToBLL(this D.Cinema entity) // Ajouter une dépendance pour lier avec DAL
        {
            if (entity == null) return null;
            return new CinemaBLL(entity.Id, entity.Nom, entity.Ville);
        }

        public static D.Cinema ToDAL(this CinemaBLL entity)
        {
            if (entity == null) return null;
            return new D.Cinema
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Ville = entity.Ville
            };
        }

        public static FilmBLL ToBLL(this D.Film entity)
        {
            if (entity == null) return null;
            return new FilmBLL(entity.Id, entity.Titre, entity.DateSortie);
        }

        public static D.Film ToDAL(this FilmBLL entity)
        {
            if (entity == null) return null;
            return new D.Film
            {
                Id = entity.Id,
                Titre = entity.Titre,
                DateSortie = entity.DateSortie
            };
        }

        public static DiffusionBLL ToBLL(this D.Diffusion entity)
        {
            if (entity == null) return null;
            return new DiffusionBLL(
                entity.Id, 
                entity.DateDiffusion, 
                null, // Pour le moment on ne peut pas mettre de film ni de cinema dans le constructeur donc on met null
                null
                ); 
        }

        public static D.Diffusion toDAL(this DiffusionBLL entity)
        {
            if (entity == null) return null;
            return new D.Diffusion
            {
                Id = entity.Id,
                DateDiffusion = entity.DateDiffusion,
                Cinema_Id = entity.Cinema.Id,
                Film_Id = entity.Film.Id
            };
        }
    }
}
