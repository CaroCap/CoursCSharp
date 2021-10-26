using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesBase
{
    #region celcius/farenheit
    struct Farenheit
    {
        public double Temperature;

        public Celcius Conversion()
        {
            Celcius result;
            result.Temperature = (Temperature - 32) * 5.0/9.0 ;
            return result;
        }

    }

    struct Celcius
    {
        public double Temperature;

        public Farenheit Conversion()
        {
            Farenheit result;
            result.Temperature = (Temperature * (9.0 / 5.0)) + 32;
            return result;
        }

    }
    #endregion

    #region exosup Methode
    struct Exercice
    {
        public int TailleTableau()
        {
            int tailleTab;
            do
            {
                Console.WriteLine("Entrez la taille du tableau à crée : ");
            } while (!int.TryParse(Console.ReadLine(), out tailleTab));
            return tailleTab;
        }

        public void RemplirTab(int[] tab)
        {
            for(int i = 0; i< tab.Length; i++)
            {
                int saisieClavier;
                do
                {
                    Console.WriteLine($"Entrez le nombre entier {i+1} à introduire dans le tableau : ");
                } while (!int.TryParse(Console.ReadLine(), out saisieClavier));
                tab[i] = saisieClavier;
            }
        }

        public double Moyenne(int[] tab)
        {
            int somme =0;
            foreach(int nbr in tab)
            {
                somme += nbr;
            }
            double resultat = (double)somme / tab.Length;
            return resultat;
        }
    }
    #endregion

    #region film
    struct Film
    {
        public string titre;
        public int cote;
    }

    struct Cinema
    {
        public void AjouterFilm(List<Film> Movies)
        {
            int nbrFilm;
            do
            {
                Console.WriteLine("Entrez le lmbre de film à l'affiche : ");
            } while (!int.TryParse(Console.ReadLine(), out nbrFilm) || nbrFilm <= 0);

            for (int i = 0; i < nbrFilm; i++)
            {
                Film film;
                Console.WriteLine($"Entre le titre du film {i + 1} : ");
                film.titre = Console.ReadLine();
                Console.WriteLine($"Entre la du film {i + 1} : ");
                film.cote = int.Parse(Console.ReadLine());
                Movies.Add(film);
            }
        }

        public void AfficherFilms(List<Film> Movies)
        {
            foreach (Film film in Movies)
            {
                Console.WriteLine($"titre : {film.titre} - cote {film.cote}");
            }
        }

        public Film MeilleurFilm(List<Film> Movies)
        {
            int indexMeilleurFilm = 0, meilleurCote = -1;
            foreach (Film film in Movies)
            {
                if (film.cote > meilleurCote)
                {
                    meilleurCote = film.cote;
                    indexMeilleurFilm = Movies.IndexOf(film);
                }
            }
            return Movies[indexMeilleurFilm];

        }

    }

    #endregion

    #region famille
    struct Personne
    {
        public string Prenom;
        public string Passion;
        public int age;
    }
    struct Famille
    {
        public void MembreDeLaFamille(List<Personne> famille)
        {
            int nbr;
            do
            {
                Console.WriteLine("Entrez le nombre de personne dans la famille : ");
            } while (!int.TryParse(Console.ReadLine(), out nbr) || nbr <= 1);

            for (int i = 0; i < nbr; i++)
            {
                Personne personne;
                Console.WriteLine($"Entre le prenom de la personne  {i + 1} : ");
                personne.Prenom = Console.ReadLine();
                Console.WriteLine($"Entre le hobby de la personne  {i + 1} : ");
                personne.Passion= Console.ReadLine();
                Console.WriteLine($"Entre l'age de la personne {i + 1} : ");
                personne.age = int.Parse(Console.ReadLine());
                
                famille.Add(personne);
            }
        }

        public void AfficheLesAdultes(List<Personne> famille)
        {
            foreach(Personne personne in famille)
            {
                if (personne.age >= 18)
                {
                    Console.WriteLine($"prenom = {personne.Prenom} - age : {personne.age} - passion : {personne.Passion}");
                }
            }
        }

        public void AfficheLesEnfants(List<Personne> famille)
        {
            foreach (Personne personne in famille)
            {
                if (personne.age < 18)
                {
                    Console.WriteLine($"prenom = {personne.Prenom} - age : {personne.age} - passion : {personne.Passion}");
                }
            }
        }

        public void Retirer(List<Personne> famille, Personne pers)
        {
            famille.Remove(pers);
        }

        public Personne LePlusJeune(List<Personne> famille)
        {
            int indexPlusJeune = 0, plusJeune = int.MaxValue;
            foreach (Personne personne in famille)
            {
                if (personne.age < plusJeune)
                {
                    plusJeune = personne.age;
                    indexPlusJeune = famille.IndexOf(personne);
                }
            }
            return famille[indexPlusJeune];
        }
    }
    #endregion

    #region mathematique
    struct Mathematique
    {
        public double Addition(double nbr1, double nbr2)
        {
            return nbr1 + nbr2;
        }

        public double soustraction(double nbr1, double nbr2)
        {
            return nbr1 - nbr2;
        }
        public double multiplication(double nbr1, double nbr2)
        {
            return nbr1 * nbr2;
        }
        public double division(double nbr1, double nbr2)
        {
            if (nbr2 == 0)
            {
                Console.WriteLine("Division par 0 impsssible");
                return 0;
            }
            return nbr1 / nbr2;
        }
    }

    #endregion

    #region enum cartes
    public enum Couleurs 
    { 
        COEUR,
        PIQUE,
        CARREAU,
        TREFLE
    }

    public enum Valeurs 
    { 
        DEUX = 2,
        TROIS,
        QUATRE,
        CINQ,
        SIX,
        SEPT,
        HUIT,
        NEUF,
        DIX,
        VALET,
        DAME,
        ROI,
        AS
    }

    struct Carte
    {
        public Couleurs couleur;
        public Valeurs valeur;
    }
    #endregion
}
