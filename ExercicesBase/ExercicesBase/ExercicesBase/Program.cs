using System;
using System.Collections.Generic;

namespace ExercicesBase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region methode celcius farenheit
            //Console.WriteLine("Entrez la température à convertir : ");
            //double temp = double.Parse(Console.ReadLine());
            //Celcius C;
            //C.Temperature = temp;
            ////Console.WriteLine(C.Conversion().Temperature);
            //Farenheit F;
            //F.Temperature = temp;
            ////Console.WriteLine(F.Conversion().Temperature);

            //Console.WriteLine("Je converti en Celcius(1) ou fanrenheit(2)  : ");
            //int choix = int.Parse(Console.ReadLine());

            //if (choix == 1)
            //{

            //    Console.WriteLine(F.Conversion().Temperature);
            //}

            #endregion

            #region exoSup Methode

            //créer une structure exercice avec 
            //une fonction qui demande çà l'utilisateur d'introduire un nombre entier(taille du tableau)
            //créer un tableau en fonction de la taille entrée
            //une méthode pour remplir le tableau d'entier(c'est l'utilisateur qui entre les valeurs)
            //une fonction qui va calculer la moyenne
            //Exercice E;
            //Console.WriteLine(E.TailleTableau());
            //int[] TableauDeNotes = new int[E.TailleTableau()];
            //E.RemplirTab(TableauDeNotes);
            //foreach(int nbr in TableauDeNotes)
            //{
            //    Console.WriteLine(nbr);
            //}


            //Console.WriteLine("La moyenne des nombre introduit dans le tableau est : " + E.Moyenne(TableauDeNotes));
            #endregion

            #region exoSup Cinema
            /*
             Créer une structure film avec comme propriété un titre(string) et une cote (int)
             Créer une liste de film
             Créer une structure cinema avec 3 méthodes:
                    1- une procédure qui demande à l'utilisateur combien de film sont à l'affiche
                       et qui ensuite permet à l'utilisateur d'ajouter ce nombre de film à la liste
                    2- une procédure qui affiche les films et leur cote
                    3- une fonction qui renvois le film ayant la meilleur cote
             */
            //Cinema cine;
            //List<Film> Movies = new List<Film>();
            //cine.AjouterFilm(Movies);
            //cine.AfficherFilms(Movies);
            //Film f = cine.MeilleurFilm(Movies);
            //Console.WriteLine(f.titre);
            #endregion

            #region exoSup Famille
            /*Créer une structure Personne avec comme propriété un Prenom(string), Passion(string) et age(int)
             Créer une liste de film
             Créer une structure cinema avec les méthodes:
                    1-Une procédure pour l'utilisateur ajouter des membres à la famille 
                    2-Une procédure qui affiche les enfants (- de 18 ans)
                    3-Une procédure qui affiche les adultes (18 ans et plus)
                    4-Une procéure pour supprimer une membre de la famille
                    5-Une fonction pour récupérer le plus jeun membre de la famille
             */
            #endregion

            #region famille
            //Famille Adnet;
            //List<Personne> maFamille = new List<Personne>();
            //Adnet.MembreDeLaFamille(maFamille);
            //Adnet.AfficheLesAdultes(maFamille);
            //Personne personne = maFamille[0];
            //Adnet.Retirer(maFamille, personne);
            //Console.WriteLine("----------------");
            //Adnet.AfficheLesAdultes(maFamille);
            //Console.WriteLine("le plus jeune membre de la famille est : ");
            //Personne jeune = Adnet.LePlusJeune(maFamille);
            //Console.WriteLine(jeune.Prenom);
            #endregion

            #region mathematique
            Mathematique calcul;
            Console.WriteLine("test math");
            Console.WriteLine(calcul.division(9,0));
            #endregion

            #region enum cartes
            Carte[] deck = new Carte[52];
            int i = 0;
            //Pour chauque couleur c  dans l'énumération couleurs
            // pour chauqe valeur v dans l'enumartion valeurs
            //  le deck à l'index i aura pour couleur c
            //  le deck à l'index i aura pour valeur v
            //  augmanter l'index

            //si je veux créer une carte je dois lui associer une
            //une couleur venant de l'enumaration Couleurs
            //et une valeur venant de l'enunmeration Valeurs
            Carte carte2;
            carte2.couleur = Couleurs.COEUR;
            carte2.valeur = Valeurs.CINQ;

            Console.WriteLine((int)carte2.valeur);

            foreach (Couleurs C in Enum.GetValues(typeof(Couleurs)))
            {
                foreach (Valeurs V in Enum.GetValues(typeof(Valeurs)))
                {
                    deck[i].couleur = C;
                    deck[i].valeur = V;
                    i++;
                }
            }


            //foreach (Carte carte in deck)
            //{
            //    Console.WriteLine($"{carte.couleur} - {carte.valeur}");
            //}

            //Je change la couleur de fond de la console
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //je fais une boucle pour parcourir mon deck
            foreach (Carte carte in deck)
            {
                //en fonction de la couleur de la carte je change l'afficge
                switch (carte.couleur)
                {
                    case Couleurs.CARREAU:
                    case Couleurs.COEUR:
                        //je change la couleur d'écriture (foregroundcolr)
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Couleurs.PIQUE:
                    case Couleurs.TREFLE:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }
                Console.WriteLine(carte.couleur.ToString() + " - " + carte.valeur.ToString());
            }

            #endregion



        }



    }
}
