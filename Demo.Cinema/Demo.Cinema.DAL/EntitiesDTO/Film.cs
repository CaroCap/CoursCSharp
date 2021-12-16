using System;

namespace Demo.Cinema.DAL.EntitiesDTO
{
    public class Film
    {
        //decimal préférence, utiliser les mêmes noms de colonnes pour faciliter notre compréhension
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateSortie { get; set; }
    }
}
