using System;
using System.Collections.Generic;


namespace CSharpObjet
{
    #region Exercice Methode
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
            for (int i = 0; i < tab.Length; i++)
            {
                int saisieClavier;
                do
                {
                    Console.WriteLine($"Entrez le nombre entier {i + 1} à introduire dans le tableau : ");
                } while (!int.TryParse(Console.ReadLine(), out saisieClavier));
                tab[i] = saisieClavier;
            }
        }
        public double Moyenne(int[] tab)
        {
            int somme = 0;
            foreach (int nbr in tab)
            {
                somme += nbr;
            }
            double resultat = (double)somme / tab.Length;
            return resultat;
        }
    }
    #endregion

    #region Film au Cinema

    struct Film
    {
        public string Titre;
        public int Cote;
    }

    struct Cinema
    {
        public void AjouterFilm(List<Film> Movies)
        {
            int nbreFilm;
            Film Affiche;
            do
            {
                Console.WriteLine("Combien de films sont à l'affiche ? ");
            } while (!int.TryParse(Console.ReadLine(), out nbreFilm));

            for (int i = 0; i < nbreFilm; i++)
            {
                Console.WriteLine($"Entrez le titre du film N° {i+1} : ");
                Affiche.Titre = Console.ReadLine();
                Console.WriteLine($"Entrez la cotation du film N° {i+1} : ");
                int.TryParse(Console.ReadLine(), out Affiche.Cote);
                Movies.Add(Affiche);
            }
        }

        public void AfficherFilms(List<Film> Movies)
        {
            foreach (Film item in Movies)
            {
               Console.WriteLine(item.Titre + " " + item.Cote);
            }
        }

        /*public string MeilleurFilm(List<Film> Movies)
        {
            string meilleurTitre = "";
            int meilleureCote = 0;
            
            foreach (Film item in Movies)
            {
                if (item.Cote > meilleureCote)
                {
                    meilleureCote = item.Cote;
                    meilleurTitre = item.Titre;
                }
            }
            return meilleurTitre;
        }*/

        public Film MeilleurFilm(List<Film> Movies)
        {
            Film best;
            best.Titre = "";
            best.Cote = -1;

            /*string meilleurTitre = "";
            int meilleureCote = 0;*/

            foreach (Film item in Movies)
            {
                if (item.Cote > best.Cote)
                {
                    best.Cote = item.Cote;
                    best.Titre = item.Titre;
                }
            }
            return best;
        }
    }


    //CORRECTION
    //
    /*
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
    }*/

    #endregion

    #region Famille
    struct Personne
    {
        public string Prenom;
        public string Passion;
        public int Age;
    }
    struct Famille
    {
        public void AjouterMembre(List<Personne> famille)
        {
            int nbreMembresFamille;
            Personne Membre;
            do
            {
                Console.WriteLine("Combien de personne dans la famille ? ");
            } while (!int.TryParse(Console.ReadLine(), out nbreMembresFamille));

            for (int i = 0; i < nbreMembresFamille; i++)
            {
                Console.WriteLine($"Entrez le Prénom du Membre N°{i + 1} : ");
                Membre.Prenom = Console.ReadLine(); 
                Console.WriteLine($"Entrez la Passion du Membre N°{i + 1} : ");
                Membre.Passion = Console.ReadLine();
                Console.WriteLine($"Entrez l'âge du Membre N°{i + 1} : ");
                int.TryParse(Console.ReadLine(), out Membre.Age);
                famille.Add(Membre);
            }
        }
        public void AfficheLesAdultes(List<Personne> famille)
        {
            foreach (Personne adulte in famille)
            {
                if (adulte.Age >= 18)
                {
                    Console.WriteLine(adulte.Prenom + " " + adulte.Passion + " " + adulte.Age + " ans");
                }
            }
        }
        public void AfficheLesEnfants(List<Personne> famille)
        {
            foreach (Personne enfant in famille)
            {
                if (enfant.Age < 18)
                {
                    Console.WriteLine(enfant.Prenom + " " + enfant.Passion + " " + enfant.Age + " ans");
                }
            }
        }
        public void Retirer(List<Personne> famille, Personne pers)
        {
            /*do
            {
                Console.WriteLine("Quel Membre Souhaitez vous supprimer de la Famille ?");
                for (int i = 0; i < famille.Count; i++)
                {
                    foreach (Personne membre in famille)
                    {
                        Console.WriteLine($"{i + 1}." + membre.Prenom + " ");
                    }
                }
            }while (Console.ReadLine)

            famille.RemoveAt(famille.IndexOf(pers));*/

            famille.Remove(pers);
        }

        public Personne LePlusJeune(List<Personne> famille)
        {
            Personne Younger;
            Younger.Prenom = "";
            Younger.Passion = "";
            Younger.Age = 1000;
            //int indexYounger = -1;

            foreach (Personne item in famille)
            {
                if (item.Age < Younger.Age)
                {
                    Younger.Age = item.Age;
                    Younger.Prenom = item.Prenom;
                    Younger.Passion = item.Passion;
                    //indexYounger = famille.IndexOf(item);
                }
            }
            return Younger;
            //return famille[indexYounger];
            }
        }
    #endregion

    #region Mathematique
    struct Mathematique
    {
        public double addition(double nbr1, double nbr2)
        {
            return nbr1 + nbr2;
            //double resultat = nbr1 + nbr2;
            //return resultat;
        }
        public double soustraction(double nbr1, double nbr2)
        {
            return nbr1 - nbr2;
            //double resultat = nbr1 - nbr2;
            //return resultat;
        }
        public double multiplication(double nbr1, double nbr2)
        {
            //double resultat = nbr1 * nbr2;
            //return resultat;
            return nbr1 * nbr2;
        }
        public double division(double nbr1, double nbr2)
        {
            if (nbr2 == 0)
            {
                Console.WriteLine("Désolé, Nous ne pouvons pas diviser par zéro");
                return 0;
            }
            return nbr1 / nbr2;
        }
    }

    #endregion

    #region Cartes
    public enum Couleurs {COEUR, PIQUE, TREFLE, CARREAU}
    public enum Valeurs {AS = 14, DEUX = 2, TROIS = 3, QUATRE = 4, CINQ = 5, SIX =6, SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13 }
    struct Carte
    {
        public Couleurs couleur;
        public Valeurs valeur;
    }

    #endregion


}


