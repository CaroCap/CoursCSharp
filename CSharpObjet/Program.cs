using System;
using System.Collections.Generic;

namespace CSharpObjet
{
    #region Conversion Temperature Celsius Farenheit
    struct Farenheit
    {
        public double Temperature;
        public Celsius Conversion()
        {
            Celsius result;
            result.Temperature = Temperature * 9 / 5 + 32;
            return result;
        }
    }

    struct Celsius
    {
        public double Temperature;
        public Farenheit Conversion()
        {
            Farenheit result;
            result.Temperature = (Temperature - 32) / 9 * 5;
            return result;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Temperature
            Celsius degres;
            degres.Temperature = 25;
            Console.WriteLine(degres.Conversion().Temperature);
            #endregion


            #region Exercice methode
            //créer une structure exercice avec
            //une fonction qui demande çà l'utilisateur d'introduire un nombre entier(taille)
            //créer un tableau en fonction de la taille entrée
            //une méthode pour remplir le tableau d'entier(c'est l'utilisateur qui entre les valeurs)
            //une fonction qui va calculer la moyenne
            Exercice E;
            //Console.WriteLine(E.TailleTableau());
            int[] TableauDeNotes = new int[E.TailleTableau()];
            E.RemplirTab(TableauDeNotes);
            //foreach(int nbr in TableauDeNotes)
            //{
            // Console.WriteLine(nbr);
            //}

            Console.WriteLine("La moyenne des nombre introduit dans le tableau est : " + E.Moyenne(TableauDeNotes));
            #endregion

            #region Cinema
            Cinema cine;
            List<Film> Movies = new List<Film>();
            cine.AjouterFilm(Movies);
            cine.AfficherFilms(Movies);
            Film f = cine.MeilleurFilm(Movies);
            Console.WriteLine(f.Titre);
            #endregion


            #region Famille
            // Créer une structure Personne avec comme propriété un Prenom(string), Passion(string) et age(int)
            // Créer une liste de famille
            // Créer une structure famille avec les méthodes:
            //        1-Une procédure pour l'utilisateur ajouter des membres à la famille 
            //        2-Une procédure qui affiche les enfants (- de 18 ans)
            //        3-Une procédure qui affiche les adultes (18 ans et plus)
            //        4-Une procéure pour supprimer un membre de la famille
            //        5-Une fonction pour récupérer le plus jeun membre de la famille
            //
            Famille Cap;
            List<Personne> MembresFamille = new List<Personne>();
            Cap.AjouterMembre(MembresFamille);
            Console.WriteLine("Voici les adultes de la Famille : ");
            Cap.AfficheLesAdultes(MembresFamille);
            Console.WriteLine("Voic les enfants de la Famille : ");
            Cap.AfficheLesEnfants(MembresFamille);
            Personne p = MembresFamille[0];
            Cap.Retirer(MembresFamille, p);
            Console.WriteLine("Le plus jeune membre de la Famille est : ");
            Personne jeune = Cap.LePlusJeune(MembresFamille);
            Console.WriteLine(jeune.Prenom);
            #endregion
            

            #region Mathematique
            Mathematique Calcul;

            double nbr1 = 1;
            double nbr2 = 1;
            do
            {
                Console.WriteLine("Introduisez un premier nombre :");
            } while (!double.TryParse(Console.ReadLine(), out nbr1));
            do
            {
                Console.WriteLine("Introduisez un deuxième nombre :");
            } while (!double.TryParse(Console.ReadLine(), out nbr2));
            string choix = "";
            do
            { 
                
                    Console.WriteLine("\nQuel calcul souhaitez-vous faire ? " +
                        "\n 1. Addition" +
                        "\n 2. Soustraction" +
                        "\n 3. Multiplication" +
                        "\n 4. Division" +
                        "\n 5. Quitter le programme");
                    choix = Console.ReadLine();
                    switch (choix)
                    {
                        case "1":
                            Console.WriteLine($"L'addition de {nbr1} et de {nbr2} est égal à " + Calcul.addition(nbr1, nbr2));
                            break;
                        case "2":
                            Console.WriteLine($"La soustraction de {nbr1} et de {nbr2} est égal à " + Calcul.soustraction(nbr1, nbr2));
                            break;
                        case "3":
                            Console.WriteLine($"La mutliplication de {nbr1} et de {nbr2} est égal à " + Calcul.multiplication(nbr1, nbr2));
                            break;
                        case "4":
                            Console.WriteLine($"La division de {nbr1} et de {nbr2} est égal à " + Calcul.division(nbr1, nbr2));
                            break;
                        default:
                            Console.WriteLine("Ceci n'est pas un choix valide");
                            break;
                    }
            } while (choix !="5");
            Console.WriteLine("Merci Aurevoir");
            #endregion
             
             */

            #region Cartes
            /*Créer une énumération pour les couleurs(Coeur, Carreau, Pique, Trefle)
             * Créer une énumération pour les valeurs(as = 14, deux = 2, trois = 3, ..., Roi = 13)
             * Créer une structure Carte qui contient deux variables publiques:
             * Couleur de type Couleurs
             * Valeur de type Valeurs
             * Déclarer un tableau de Carte d'une taille de 52
             * À l'aide d'une boucle « foreach » définir les couleurs et les valeurs de chacune des cartes
             * Afficher les cartes(Définir si cela fonctionne: si oui pourquoi, sinon pourquoi)*/

            Carte[] deck = new Carte[52];
            int compteur = 0;     
            foreach (Couleurs famille in Enum.GetValues(typeof(Couleurs)))
            {
                foreach (Valeurs V in Enum.GetValues(typeof(Valeurs)))
                {
                    deck[compteur].couleur = famille;
                    deck[compteur].valeur = V;
                    compteur++;
                }
            }
                foreach (Carte item in deck)
                {
                    Console.WriteLine(item.couleur + " " + item.valeur);
                }
                #endregion
        }
    }
}
