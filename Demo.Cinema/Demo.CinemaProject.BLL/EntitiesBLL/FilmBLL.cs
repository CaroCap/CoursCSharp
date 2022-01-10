using System;

namespace Demo.CinemaProject.BLL.EntitiesBLL
{
    public class FilmBLL
    {
        // Propriétés comme dans le DAL
        public int Id { get; set; }
        private string _titre;
        public string Titre
        {
            get { return _titre; }
            set {
                string newTitre = value.Trim(); //.Trim = pour supprimer les espaces blancs avant et à la fin de la string
                if (string.IsNullOrEmpty(newTitre)) throw new ArgumentNullException(nameof(newTitre));
                if(newTitre.Length > 128)
                {
                    throw new ArgumentOutOfRangeException(nameof(newTitre));
                }
            }
        }
        public DateTime DateSortie { get; set; }

        //Constructeur
        public FilmBLL(int id, string titre, DateTime dateSortie)
        {
            Id = id;
            Titre = titre;
            DateSortie = dateSortie;
        }

        public void ReportMovieRelease(DateTime newDate)
        {
            DateSortie = newDate;
        }
    }
}