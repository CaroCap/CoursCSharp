using System;

namespace Demo.CinemaProject.BLL.EntitiesBLL
{
    public class DiffusionBLL
    {
        // Propriétés comme dans DAL
        public int Id { get; set; }
        public DateTime DateDiffusion { get; set; }

        // Contrairement au DAL où on avait les id de film et les id de cinema, ici on veut directement travailler avec les classes
        //public int Cinema_Id { get; set; }
        //public int Film_Id { get; set; }
        public CinemaBLL Cinema { get; set; }
        public FilmBLL Film { get; set; }

        // Constructeur (ctor + tab = raccourci)
        public DiffusionBLL(int id, DateTime dateDiff, CinemaBLL cinema, FilmBLL film)
        {
            // vérifier que film est déjà sorti avant de pouvoir le diffuser)
            if (film.DateSortie > dateDiff) throw new ArgumentException();
            Id = id;
            DateDiffusion = dateDiff;
            Cinema = cinema;
            Film = film;
        }
    }
}