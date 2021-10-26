using System;

namespace RevisionsFondamental
{
    /**
     * EXERCICES RECAPITULATIFS
     * 
     * Voici 3 exercices qui reprennent bien tous les concepts vus précédemment pendant le cours de C#
     * 
     * Vous pouvez choisir celui ou ceux qui vous intéressent.  Il y a un jeu, un système de déplacement
     * une grille, et une demande d'une application de gestion des réservations de chambre d'un hôtel
     * paradisiaque
     * 
     * Je vous souhaite un bon travail et surtout pas de panique, vous avez déjà fait des choses similaires
     * dans d'autres exercices.  N'hésitez pas à aller les revoir pour vous aider et/ou inspirer !
     * 
     * Greg 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercices récapitulatifs C# FONDAMENTAL");
            //Aide_Random();
            Aide_Bordures();
            //Aide_CarreRouge();
            //Aide_SwitchEnum();

        }

        /**
         * Jeu du Pendu
         * 
         * Réaliser un jeu du pendu qui va demander à l'utilisateur
         * de trouver un mot en un nombre fixé d'essais.
         * 
         * Créer un tableau de string qui va stocker quelques mots à trouver
         * Choisir aléatoirement un mot pour la partie (Random --> cfr AideRandom)
         * Lancer la partie
         * 
         * La partie se termine :
         *  - soit quand le joueur trouve en moins d'essais que le nombre maximal fixé (VICTOIRE)
         *  - soit quand le joueur ne trouve pas (DEFAITE)
         *  
         *  Affichage :
         *  Le mot à trouver doit apparaître sous cette forme  * * * * * * * *
         *  ou chaque étoile représente un caractère.
         *  Remplacer les étoiles par les lettres déjà trouvées  * * a * t * *
         *  Afficher le nombre d'essais restants
         *  Afficher une notification de victoire ou défaite à la fin
         *  
         *  Bonus : 
         *  Afficher aussi le pendu à chaque étape 
         */

        /**
         * Grille de Jeu
         * 
         * Créer une grille de 15 cases sur 15 cases
         * Placer dans la première case un pion (P) qui va pouvoir
         * se déplacer au sein de la grille en utilisant les touches
         * HAUT, BAS, GAUCHE, DROITE (Console.ReadKey())
         * 
         * Vous devez gérer les bords et empêcher votre pion de "sortir"
         * de la grille
         * 
         * Placer aléatoirement une sortie (S) dans votre grille
         * Quand le pion se déplace jusqu'à la sortie, votre programme
         * s'arrête 
         * 
         * Affichage :
         *  - Créer une grille stylisée (cfr -> Aide_Bordures())
         */

        /**
         * Saint-Anne : Royal Seychelles Resort
         * 
         * Vous devez réaliser le système de réservation des chambres d'un hôtel de luxe.
         * 
         * Une réservation va devoir enregistrer différentes données :
         * - N° de Chambre
         * - Nb de personnes
         * - Nom et Prénom de chaque personne
         * - Date d'arrivée
         * - Date de départ
         * - Liste des options
         * - Prix total HTVA
         * 
         * et être capable de fournir différents actions :
         * - être affichée
         * - calculer le nombre de jours d'occupation
         * - calculer le prix TVAC de l'ensemble des données
         * 
         * INFORMATIONS DE L'HOTEL
         * 
         * L'hôtel comporte 20 chambres au total qui sont réparties en :
         * - 2 suites nuptiales (MAX 2 personnes)
         * - 4 chambres d'une personne
         * - 10 chambres de 2 personnes
         * - 4 chambres de 4 personnes
         * 
         * Le prix (de votre choix) est fixé par personne et évolue
         * 
         * - La suite est facturée 250% du prix initial par personne
         * - Chaque personne supplémentaire est facturée avec une remise qui se calcule comme suit
         * 
         *     Ex : prix initial / personne -> 100 EUR
         *          - SUITES : 250 EUR / pers
         *          - 2 personnes : ( 100 + 100 * 0.85) = 185 EUR (remise de 15 % pour la deuxième personne)
         *          - 3 personnes : (100 + 100 * 0.85 + 100 * 0.7) = 255 EUR 
         *          - 4 personnes : (100 + 100 * 0.85 + 100 * 0.7 + 100 * 0.55) = 310 EUR
         *          
         * Vous pouvez aussi configurer par chambre différentes options
         * - Majordome (+ 125 EUR / jour)
         * - Repas en chambre (+ 50 EUR / perso // jour)
         * - Boissons All exclusive (+ 150 EUR / pers // semaine)
         * - Excursion : Plongée sous marine  (+ 125 EUR / pers)
         * - ... laissez libre recours à votre imagination :)
         * 
         * APPLICATION DE RESERVATIONS
         * 
         * Le gérant de l'hôtel doit être capable d'effectuer ces différentes actions :
         *      
         *      1. Ajouter une nouvelle réservation
         *      2. Afficher toutes ces réservations (commencer avec juste un mois par facilité)
         *      3. Ouvrir sa comptabilité
         *          3.a Calculer le montant total des réservations en cours
         *          3.b Rechercher une réservation par un nom de personne et l'afficher
         *      4. Quitter
         *      
         * Bonus :
         * 
         * Afficher les réservations dans une grille qui représente le mois en cours
         * (cfr -> Aide_Bordures).  Pour des raisons de limitations de l'organisation 
         * de l'affichage dans la console, vous pouvez seulement remplir un carré de couleur
         * dans le jour ad hoc et d'y placer le numéro de chambre. (cfr -> Aide_CarreRouge)
         * 
         * Faites-moi réver !
         */



        static void Aide_Random()
        {
            // Déclaration d'une variable Random et instanciation (new)
            Random random = new Random();

            // Afficher 100 X un nombre aléatoire compris entre 1 et 10
            // ATTENTION : borne supérieure non incluse !!!
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(random.Next(1, 11));
            }
        }

        static void Aide_Bordures()
        {
            // Affichage d'un P dans un carré
            // Liste des bordures disponibles en console (UNICODE)
            // https://www.fileformat.info/info/unicode/block/box_drawing/list.htm
            Console.Write("\u250C\u2500\u2500\u2500\u2510\n");
            Console.Write("\u2502 P \u2502\n");
            //Console.Write("\u2514\u2500\u2500\u2500\u2518\n");
        }

        static void Aide_CarreRouge()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" 5 "); // les 3 espaces vont avoir un fond rouge 
            Console.BackgroundColor = ConsoleColor.Black; // Refixer le fond en noir pour eviter
                                                          // que tout reste rouge
        }

        enum Occupation
        {
            Vacances,
            Famille,
            Travail
        }

        static void Aide_SwitchEnum()
        {
            Occupation o = Occupation.Vacances;
            
            switch (o)
            {
                case Occupation.Vacances:
                    Console.WriteLine("Je suis en vacances");
                    break;
                case Occupation.Famille:
                    Console.WriteLine("Je suis en famille");
                    break;
                case Occupation.Travail:
                    Console.WriteLine("Je suis au travail");
                    break;
                default:
                    Console.WriteLine("Je ne sais pas où je suis");
                    break;
            }
        }


    }
}
