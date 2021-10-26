using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFilm.models
{
    public class Film 
    {
        public string Titre { get; set; }

        private int _anneeSortie;

        public int AnneeSortie
        {
            get
            {
                return _anneeSortie;
            }

            set
            {
                if (value > 1891)
                {
                    _anneeSortie = value;
                }
                else 
                { 
                    Console.WriteLine("Le Cinéma a été inventé en 1891"); 
                }
            }
        }

        public Acteur acteurPrincipal { get; set; }

        public Realisateur leRealisateur { get; set; }
    }
}
