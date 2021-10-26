using System;
using System.Collections.Generic;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciceVariables();
            //ExerciceOperateurs();
            //ExSecondes();
            //CorrectionConvertisseurSecondes();
            //Conversion();
            //ConditionsBissextile();
            //ConditionsTennis();
            //ConditionsBoissons();
            //ConditionsCalculatrice();
            //ConditionsDurees();
            //ConditionsPaire();
            //CompteBanquaire();
            //BoucleTable();
            //LanceurBalle();
            //DoubleMultiplication();
            //Etoile();
            //BoucleBoissons();
            //BoucleMotDePasse();
            //Tableau1();
            //Tableau1b();
            //Tableau2(); 
            //Tableau3(); 
            //Tableau4();
            //TableauPion();
            //ListeBulletin();
            //CalculEcrit();
            //StructureLivre();
            //Exercice_celsius();
            //MagasinDeVetements();
            //Pendu();

        }

        #region JEU DU PENDU
        static void Pendu()
        {   /** JEU DU PENDU
            * Réaliser un jeu du pendu qui va demander à l'utilisateur
            * de trouver un mot en un nombre fixé d'essais.*/
            //* Créer un tableau de string qui va stocker quelques mots à trouver
            //* Choisir aléatoirement un mot pour la partie (Random --> cfr AideRandom)
            /*  static void Aide_Random()
                {   Random random = new Random();
                    // Afficher 100 X un nombre aléatoire compris entre 1 et 10
                    // ATTENTION : borne supérieure non incluse !!!
                    for (int i = 0; i < 100; i++)
                    { Console.WriteLine(random.Next(1, 11));  }
                }*/
            //SI 1 JOUEUR => ALEATOIRE // SI MULTI JOUEURS => Proposition d'un des joueurs



            // Changement esthétique Console Background et couleur texte
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;


            string choixJoueur = "";
            string motATrouverString = "";

            do
            {
                Console.WriteLine("Quel mode de jeu ?" +
                "\n1. Monogame" +
                "\n2. MultiPlayer");
                choixJoueur = Console.ReadLine();
            } while (choixJoueur != "1" && choixJoueur != "2");

            switch (choixJoueur)
            {
                case "1": // Aléatoire
                    string[] mots = new string[] { "CHOCOLAT", "FRITEUSE", "HORTICULTURE", "APICULTEUR", "DECAPSULER" };
                    Random random = new Random();
                    motATrouverString = mots[random.Next(0, mots.Length - 1)];
                    break;
                case "2": // Multijoueurs
                    Console.WriteLine("Choisissez un mot à faire deviner : ");
                    motATrouverString = (Console.ReadLine()).ToUpper();
                    break;
            }

            // Transformer String en Char
            char[] motATrouverChar = motATrouverString.ToCharArray();

            /*//Faire apparaitre mot à trouver pour Tests
            foreach (char lettre in motATrouverChar)
            { Console.Write(lettre + " ");  }           */


            //* Lancer la partie - La partie se termine :
            //*  - soit quand le joueur trouve en moins d'essais que le nombre maximal fixé (VICTOIRE)
            //*  - soit quand le joueur ne trouve pas (DEFAITE)            //*  
            //*  Affichage :
            //*  Le mot à trouver doit apparaître sous cette forme  * * * * * * * *
            //*  ou chaque étoile représente un caractère.
            //*  Remplacer les étoiles par les lettres déjà trouvées  * * a * t * *
            //*  Afficher le nombre d'essais restants
            //*  Afficher une notification de victoire ou défaite à la fin
            //*  BONUS : Afficher aussi le pendu à chaque étape

            
            int essaisRestant = 6;
            char proposition;
            char[] motMystereChar = new char [motATrouverChar.Length];
            string motMystereString = "";
            //Création mot mystère avec * à la place des lettres
            for (int i = 0; i < motATrouverChar.Length; i++)
            {
                motMystereChar[i] = '*';
            }
            do
            {
                do
                {
                    //DESSIN PENDU
                    // Liste des bordures disponibles en console (UNICODE)
                    // https://www.fileformat.info/info/unicode/block/box_drawing/list.htm
                    // Pour dessiner \ => '\\'
                    switch (essaisRestant)
                    {
                        case 6: // BASE => Juste la structure
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502      \n");
                            Console.Write("     \u2502      \n");
                            Console.Write("     \u2502      \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 5: // La tête
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502      \n");
                            Console.Write("     \u2502      \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 4: // Tête + corps
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502     |\n");
                            Console.Write("     \u2502      \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 3: // Tête + corps + jambe gauche
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502     | \n");
                            Console.Write("     \u2502    /  \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 2: // Tête + corps + jambe gauche + jambe droite
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502     | \n");
                            Console.Write("     \u2502    / \\ \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 1: // Tête + corps + jambe gauche + jambe droite + bras gauche
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502    /| \n");
                            Console.Write("     \u2502    / \\ \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                        case 0: //PENDU COMPLET = PERDUUUUUU // Tête + corps + jambe gauche + jambe droite + bras gauche + bras droit
                            Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("     \u2502     O\n");
                            Console.Write("     \u2502    /|\\ \n");
                            Console.Write("     \u2502    / \\ \n");
                            Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                            Console.Write("\u2502         \u2502\n");
                            Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                            break;
                    } //Dessins Pendu selon nombre essai restant

                    Console.Write("\nTrouvez une lettre qui se trouve dans le mot : ");
                //Faire apparaire le mot Mystère avec les * et les lettres trouvées    
                    foreach (char lettre in motMystereChar)
                    { 
                        Console.Write(lettre + " "); 
                    }
                Console.WriteLine($"\nIl vous reste {essaisRestant} essai(s).");
                } while (!char.TryParse(Console.ReadLine().ToUpper(), out proposition));
                //Comparer char proposition avec lettres du mot Mystère
                // + Transformer en String pour comparaison avec la bonne réponse
                motMystereString = "";
                int compteurLettreInconnu = 0;
                for (int i = 0; i < motATrouverChar.Length; i++)
                {
                    if(motATrouverChar[i] == proposition)
                    {
                        motMystereChar[i] = proposition;
                    }
                    else
                    {
                        compteurLettreInconnu++;
                    }
                    motMystereString += motMystereChar[i];
                }
                if(compteurLettreInconnu == motATrouverChar.Length)
                {
                essaisRestant--;
                }
            } while (essaisRestant > 0 && motMystereString != motATrouverString);
            if (motMystereString == motATrouverString)
            {
                Console.WriteLine($"Bravo vous avez trouvé le mot : {motATrouverString} !");
            } 
            else if (essaisRestant == 0)
            {
                Console.Write("     \u250C\u2500\u2500\u2500\u2500\u2500\u2510\n");
                Console.Write("     \u2502     O\n");
                Console.Write("     \u2502    /|\\ \n");
                Console.Write("     \u2502    / \\ \n");
                Console.Write("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510\n");
                Console.Write("\u2502         \u2502\n");
                Console.Write("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
                Console.WriteLine($"Vous avez Perdu !!! Le mot à trouver était : {motATrouverString}");
            }
            else { Console.WriteLine("ERREUR CAP"); }

        }

        #endregion

        #region Magasin de Vetements
        /* Exercice d'un magasin de vetements type E-Shop
         * Décrire un vetement comme suit :
         *  - matiere (enum)
         *  - couleur (enum)
         *  - taille (enum)
         *  - marque (string)
         *  - type (enum)
         *  - prix HTVA (double)
         *  - quantite (int)
         *  
         *  Chaque vetement peut :
         *  - être affiché (l'entireté de son contenu)
         *  - calculer son prix TVAComprise (21%)
         *  
         *  Le magasin doit pouvoir stocker un ensemble de vêtements,
         *  les afficher tous et proposer une action de vente sur le vêtement 
         *  que l'on souhaite acheter    */
        public enum Matieres
        {
            Lin,
            Coton,
            Soie,
            Cuir,
        }

        public enum Couleurs
        {
            Noir,
            Blanc,
            Bleu,
            Rouge
        }

        public enum Tailles
        {
            Small,
            Medium,
            Large,
            XLarge
        }

        public enum Types
        {
            Robe,
            Pantalon,
            Jupe,
            Short
        }

        public struct Vetements
        {
            public Matieres matiere;
            public Couleurs couleur;
            public Tailles taille;
            public string marque;
            public Types type;
            public double prixHTVA;
            public int quantite;
            public void Affichage()
            {
                Console.WriteLine($"Le vêtement type {type} de la marque {marque} est de couleur {couleur}, est fait en {matiere} et est de taille {taille}. " +
                    $"\nSon prix HTVA est de {prixHTVA} euro et il en reste {quantite} en stock.");
            }
            public void CalculPrixTVAC()
            {
                Console.WriteLine($"Le prix est de {prixHTVA + (prixHTVA * 21 / 100),0:F2} euro TVAC.");
            }
        }

        static void MagasinDeVetements()
        {
            // Création d'une variable Liste qui contiendra des Types vêtements.
            List<Vetements> stock = new List<Vetements>();

            /*// Déclaration de la variable de type de l'enum 
            Vetements v;
            // Initialisation des différentes données contenues dans la variable
            v.marque = "Levi's";
            v.matiere = Matieres.Cuir;
            v.taille = Tailles.Large;
            v.type = Types.Short;
            v.prixHTVA = 45.5;
            v.quantite = 5;
            v.couleur = Couleurs.Noir;
            // Utilisation de la variable pour l'ajouter dans notre Liste
            stock.Add(v);

            Vetements v1;
            v1.marque = "Adidas";
            v1.matiere = Matieres.Cuir;
            v1.prixHTVA = 74.95;
            v1.quantite = 3;
            v1.taille = Tailles.Medium;
            v1.type = Types.Robe;
            v1.couleur = Couleurs.Bleu;

            stock.Add(v1);
*/
        /** Magasin de vêtements
          * 1. Afficher tous les vêtements
          * 2. Acheter un vêtement
          *
          * Si je tape 1
          * Vêtement ------------------
          * ...
          *
          * Si je tape 2
          * Affichage d'un achat avec le prix TVAC
          * Retirer la quantité du stock
          *
          * --> Revenir au menu principal */
            string action = "";
            do
            {
                Console.WriteLine("\nBienvenue au CAP SHOP.");
                do
                {
                    Console.WriteLine("Que souhaitez vous faire ?" +
                    "\n 1. Afficher les vêtements ?" +
                    "\n 2. Acheter un vêtement ?" +
                    "\n 3. Encoder un nouveau vêtement ?" +
                    "\n 4. pour quitter le programme.");
                    action = Console.ReadLine();
                } while (action != "1" && action != "2" && action != "3");
                switch (action)
                {
                    case "1":
                        if (stock.Count > 0)
                        {
                            Console.WriteLine("Aujourd'hui en magasin : ");
                            foreach (Vetements item in stock)
                            {
                                item.Affichage();
                                Console.WriteLine();
                            }
                        }
                        else { Console.WriteLine("Le stock est vide"); }
                        break;
                    case "2":
                        /*if (v1.quantite > 0)
                        {
                        Console.WriteLine($"Vous avez acheté {v1.type} de la marque {v1.marque}.");
                        v1.CalculPrixTVAC();
                        v1.quantite = v1.quantite - 1;
                        Console.WriteLine($"Il reste {v1.quantite} {v1.type} en stock.");
                            stock.Clear();
                            stock.Add(v);
                            stock.Add(v1);
                        }
                        else { Console.WriteLine("Il n'y en a plus en stock."); }
                        break;*/
                        // Achat
                        // 1. Demander quel vêtement
                        // TYPE Prix

                        int choixVetement = -1;
                        do
                        {
                            Console.WriteLine("Quel vêtement voulez-vous acheter ?");
                            int compteur = 1;
                            foreach (Vetements item in stock)
                            {
                                Console.WriteLine($"{compteur}. [{item.type}] : {item.prixHTVA} EUR");
                                compteur++;
                            }
                            int.TryParse(Console.ReadLine(), out choixVetement);
                        } while (choixVetement <= 0 || choixVetement > stock.Count);

                        // Modifier le contenu de mon vêtement dans mon stock
                        //stock[choixVetement - 1].Quantite--; // INTERDIT A CAUSE DE LA STRUCTURE
                        // 2. Enlever du stock
                        Vetements p = stock[choixVetement - 1];
                        if (p.quantite > 0)
                        {
                            stock.RemoveAt(choixVetement - 1);
                            p.quantite--;
                            stock.Add(p);
                            // Afficher le prix HTVA
                            p.CalculPrixTVAC();
                        }
                        else
                        {
                            Console.WriteLine($"le vêtement [{stock[choixVetement - 1].type}] n'est plus disponible");
                        }
                        break;

                    case "3":
                        // Insérer un nouveau vêtement
                        Vetements nouveauVetement;
                        // 1. Type du Vêtement
                        // 1.a Recupérer le numéro du type de vêtement
                        int choix = -1;
                        string[] valeursEnumType = Enum.GetNames(typeof(Types));
                        do
                        {
                            int compteur = 1;
                            foreach (string type in valeursEnumType)
                            {
                                Console.WriteLine($"{compteur}. [{type}]");
                                compteur++;
                            }
                        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumType.Length);
                        // 1.b affecter à mon vêtement le type
                        nouveauVetement.type = (Types)Enum.Parse(typeof(Types), valeursEnumType[choix - 1]);
                        // 2. Marque du vêtement
                        Console.WriteLine("Entrez la marque de votre vêtement");
                        nouveauVetement.marque = Console.ReadLine();
                        //3. matiere = Matieres.Cuir;
                        choix = -1;
                        string [] valeursEnumMatiere = Enum.GetNames(typeof(Matieres));
                        do
                        {
                            int compteur = 1;
                            foreach (string matiere in valeursEnumMatiere)
                            {
                                Console.WriteLine($"{compteur}. [{matiere}]");
                                compteur++;
                            }
                        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumMatiere.Length);
                        nouveauVetement.matiere = (Matieres)Enum.Parse(typeof(Matieres), valeursEnumMatiere[choix - 1]);
                        //4.taille = Tailles.Large;
                        choix = -1;
                        string [] valeursEnumTaille = Enum.GetNames(typeof(Tailles));
                        do
                        {
                            int compteur = 1;
                            foreach (string taille in valeursEnumTaille)
                            {
                                Console.WriteLine($"{compteur}. [{taille}]");
                                compteur++;
                            }
                        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumTaille.Length);
                        nouveauVetement.taille = (Tailles)Enum.Parse(typeof(Tailles), valeursEnumTaille[choix - 1]);
                        //5.couleur
                        choix = -1;
                        string [] valeursEnumCouleur = Enum.GetNames(typeof(Couleurs));
                        do
                        {
                            int compteur = 1;
                            foreach (string couleurs in valeursEnumCouleur)
                            {
                                Console.WriteLine($"{compteur}. [{couleurs}]");
                                compteur++;
                            }
                        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumCouleur.Length);
                        nouveauVetement.couleur = (Couleurs)Enum.Parse(typeof(Couleurs), valeursEnumCouleur[choix - 1]);
                        //6.prixHTVA = 45.5;
                        double prixHTVA = 0;
                        do
                        { Console.WriteLine("Quel est le prix HTVA de ce vêtement ?");
                            double.TryParse(Console.ReadLine(), out prixHTVA); //si TryParse est faux (ex:lettres) => valeur par défaut d'un double = 0
                        } while (prixHTVA <=0);
                        nouveauVetement.prixHTVA = prixHTVA;
                         
                        //7.quantite = 5;
                        Console.WriteLine("Combien de ce vêtement en stock ?");
                        int.TryParse(Console.ReadLine(), out nouveauVetement.quantite);


                        // Afficher le nouveau vêtement encodé
                        Console.WriteLine("Les infos du nouveau vêtement encodé :");
                        nouveauVetement.Affichage();
                        Console.WriteLine("\nEst-ce correct? \n 1. Oui \n 2. Non");
                        if (Console.ReadLine() == "1")
                        {
                        //// Utilisation de la variable pour l'ajouter dans notre Liste
                        stock.Add(nouveauVetement);
                        }
                        break;
                }
            } while (action != "4");
            Console.WriteLine("Merci Aurevoir !");
        }

        #endregion


        #region Temperature 
        /** CONVERSION TEMPERATURE - STRUCTURE
     * Ecrire deux structures Celsius et Fahrenheit
     * toutes deux ayant une variable de type double
     * appelée « Temperature ».
     * Ajouter une méthode de conversion de l'un vers l'autre*/

        public struct celsius
        {
            public double temperature;
            public void conversion_temp()
            {
                Console.WriteLine($"La temperature de {temperature} °C en Fahrenheit fait {temperature * 9 / 5 + 32,0:F3}°F");
            }

        }
        public struct fahrenheit
        {
            public double temperature;
            public void conversion_temp()
            {
                Console.WriteLine($"La temperature de {temperature} °F en Celsius fait {(temperature - 32) / 9 * 5,0:F3}°C");
            }
        }
        static void Exercice_celsius()
        {
            celsius t;
            fahrenheit f;
            double x;

            do
            {
                System.Console.WriteLine("Quelle température souhaitez-vous convertir?:");
            } while (!double.TryParse(System.Console.ReadLine(), out x));
            string answer;
            do
            {
                System.Console.WriteLine("Avez-vous encodé C pour Celsius ou F pour Fahrenheit?:");
                answer = System.Console.ReadLine();
            } while (answer != "C" && answer != "F");

            if (answer == "C")
            {
                t.temperature = x;
                t.conversion_temp();
            }
            else
            {
                f.temperature = x;
                f.conversion_temp();
            }

        }
        #endregion


        #region GESTION BIBLIOTHEQUE
        /* Créer une structure qui va définir un livre
         * La structure se compose :
         * - du titre du livre
         * - son auteur
         * - les chapitres (Dictionary<string, string> Clé = Titre du chapitre, Valeur = Contenu)
         * - d'une fonction qui va afficher les différentes informations du livre
         * Créer une liste de livre et afficher l'ensemble de la liste*/
        public struct Livre
        {
            public string titre;
            public string auteur;
            public Dictionary<string, string> chapitres;

            public void Afficher()
            {
                Console.WriteLine("Titre : " + titre + "\tAuteur : " + auteur);
                foreach (KeyValuePair<string, string> chap in chapitres)
                {
                    Console.WriteLine($"Titre du chapitre : {chap.Key}");
                    Console.WriteLine(chap.Value);
                };
            }
        }
        static void StructureLivre()
        {
            List<Livre> bibliotheque = new List<Livre>();
            Livre p;
            p.titre = "Les 4 accords Toltèques";
            p.auteur = "Cuelho";
            p.chapitres = new Dictionary<string, string>
            {
                { "Chapitre 1", "Blabla bla blaaaa"},
                { "Chapitre 2", "Blabla bla blaaaa blip blap bloup"},
                { "Chapitre 3", "Blabla bla"},
                { "Chapitre 4", "Blabla bla bliiiiiiiiiiiii"},
                { "Chapitre 5", "Blabla bla bleppppppp"}
            };

            Livre p2;
            p2.titre = "Les 3 petits cochons";
            p2.auteur = "Père Castor";
            p2.chapitres = new Dictionary<string, string>
            {
                { "Maison de paille", "Blabla bla blaaaa"},
                { "Maison de bois", "Blabla bla blaaaa blip blap bloup"},
                { "Maison en pierre", "Blabla bla"},
                { "Le Loup", "Blabla bla bliiiiiiiiiiiii"},
            };

            bibliotheque.Add(p);
            bibliotheque.Add(p2);

            foreach (Livre livre in bibliotheque)
            {
                livre.Afficher();
                Console.WriteLine();
            }
        }
        #endregion

        #region Calcul Écrits - operateur ternaire
        static void CalculEcrit() //(+opérateur ternaire)
        {   /** Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par caractère. 
         * (Méthode « ToCharArray » de la classe « string »).  */

            Console.WriteLine("Entrez un premier nombre");
            String nb1 = Console.ReadLine();
            char[] tabNb1 = nb1.ToCharArray();

            Console.WriteLine("Entrez un deuxième nombre");
            String nb2 = Console.ReadLine();
            char[] tabNb2 = nb1.ToCharArray();

            // OPERATEUR TERNAIRE = affectation conditionnelle
            //                    => (Condition) ? Valeur si vrai : Valeur si faux
            int tailleGrandTableau = (tabNb1.Length > tabNb2.Length) ? tabNb1.Length : tabNb2.Length;

            // AJOUT 0 pour avoir tableaux taille égale
            if (tabNb1.Length > tabNb2.Length)
            {
                char[] newTab = new char[tailleGrandTableau];
                for (int i = 0; i < tabNb1.Length - tabNb2.Length; i++)
                {
                    newTab[i] = '0';
                }
                foreach (char item in newTab)
                {
                    Console.Write(item);
                }


                /*
                            // CALCUL
                                int[] tabSomme = new int[tailleGrandTableau];
                            for (int i = tailleGrandTableau - 1; i >= 0; i--)
                            {
                                tabSomme[i] = (int)tabNb1[i] - (int)tabNb2[i];
                            }

                            foreach (int item in tabSomme)
                            {
                            Console.WriteLine(item);
                            };*/
            }
        }
        #endregion


        #region Liste Bulletin - dictionary
            static void ListeBulletin()
            { /* Créer le bulletin de l'année d'une classe de 5 élèves
         * Le bulletin va être contenu dans un Dictionnaire où la clé est le nom de l'élève et la valeur est l'ensemble des côtes de l'année de l'élève.
         * Afficher l'ensemble des données (Nom + côtes) de tous les élèves et calculer la moyenne de chaque élève (à juste afficher)
         */

                Dictionary<string, List<int>> bulletin = new Dictionary<string, List<int>>();

                Console.WriteLine("Combien d'élèves dans la classe ? ");
                int.TryParse(Console.ReadLine(), out int nbreEleves);

                for (int i = 0; i < nbreEleves; i++)
                {
                    int pointEleve = -1;
                    List<int> cotations = new List<int>();
                    Console.WriteLine($"Quel est le nom de l'élève {i + 1} ?");
                    string nomEleve = Console.ReadLine();

                    do
                    {
                        Console.WriteLine($"Quel point à l'élève {i + 1} ? (nombre entier entre 0 et 20)  \nTapez une lettre pour sortir du programme");
                        if (pointEleve >= 0 && pointEleve <= 20)
                        {
                            cotations.Add(pointEleve);
                        }
                    } while (int.TryParse(Console.ReadLine(), out pointEleve));

                    bulletin.Add(nomEleve, cotations);
                }

                foreach (KeyValuePair<string, List<int>> item in bulletin)
                {
                    int moyenne = 0;
                    Console.Write($"Buletin de {item.Key} :\t ");
                    foreach (int item2 in item.Value)
                    {
                        Console.Write(item2 + "\t");
                        moyenne += item2;
                    }
                    Console.WriteLine($"\nLa moyenne de {item.Key} est de {(double)moyenne / item.Value.Count}/20\n");
                }
            }

        #endregion

        #region Tableau Pion qui se déplace avec boucle et conditions
        static void TableauPion()
            { /*7. Réalisez un algorithme nous permettant de déplacer un pion dans un tableau de 10 éléments.
           * Au début, le pion se trouve dans la première case du tableau. Nous pouvons ensuite le déplacer par la gauche (g), par la droite (d) ou de stopper l'algorithme (q).*/

                // DECLARATION DE MES VARIABLES
                int[] tableauPion = new int[10]; // Création d'un tableau avec 10 valeurs
                int placePion = 0; // variable pour connaitre l'emplacement (l'index) du pion => au départ à l'index 0
                ConsoleKeyInfo touche; //à déclarer ici pour qu'elle existe en dehors de la boucle


                do // Boucle pour demander une touche du clavier pour déplacer pion ou arrêter le programme
                {
                    tableauPion[placePion] = 1; // Insertion de la valeur 1 (=le pion) à l'index placePion (+ valeurs 0 dans le reste du tableau car valeur par défaut.)
                    Console.WriteLine("\nDéplacez le pion par la gauche (g), par la droite (d) ou stopper l'algorithme (q)\n");
                    for (int i = 0; i < tableauPion.Length; i++) // Boucle pour faire apparaître le tableau
                    {
                        Console.Write(tableauPion[i] + "\t ");
                    }
                    touche = Console.ReadKey();
                    if (touche.Key == ConsoleKey.D) // Si la touche est D
                    {
                        if (placePion == tableauPion.Length - 1) // Si le pion est déjà tout à droite du tableau => ne peut plus aller plus à droite
                        {
                            Console.WriteLine("\n\nImpossible d'aller plus loin");
                        }
                        else // Sinon déplacer le pion vers la droite
                        {
                            tableauPion[placePion] = 0; //écrire 0 à l'ancien emplacement du 1
                            placePion += 1; // changer l'index du nouvel emplacement du pion (ou placePion++ pour incrémenter de 1)
                        }
                    }
                    else if (touche.Key == ConsoleKey.G) // Si ils appuient sur G
                    {
                        if (placePion == 0) // Si le pion est à l'index 0 donc tout à gauche, il ne peut pas aller plus à gauche
                        {
                            Console.WriteLine("\n\nImpossible d'aller plus loin");
                        }
                        else // Sinon on déplace le pion vers la gauche en remettant 0 à la place de l'ancien 1 et en changeant l'index du pion avec -1
                        {
                            tableauPion[placePion] = 0;
                            placePion -= 1; // on pourrait aussi écrire placePion-- 
                        }
                    }
                    else // Si on tape une autre touche que D ou G ou Q
                    {
                        Console.WriteLine("\nCeci n'est pas une touche valide...");
                    }
                } while (touche.Key != ConsoleKey.Q); // Si on tape sur Q => on sort du programme
                Console.WriteLine("\n\nMerci aurevoir.");
            }

        #endregion

        #region Tableaux 1 > 4
        static void Tableau1()
            { /*1. Écrire un algorithme qui saisit 6 entiers et les stocke dans un tableau, puis affiche le contenu de ce tableau une fois qu’il est rempli.*/
                int[] tableau1 = new int[6];
                for (int i = 0; i < tableau1.Length; i++)
                {
                    tableau1[i] = i + 1;
                    Console.WriteLine(tableau1[i]);
                }
            }

        static void Tableau1b()
        {
            /* 1 BIS - demander à l'utilisateur d'introduire les entiers */
            int[] tableau1b = new int[6];
            for (int i = 0; i < tableau1b.Length; i++)
            {
                /*Console.WriteLine($"Introduire l'entier numéro {i+1}");
                int.TryParse(Console.ReadLine(), out int entier);
                tableau1b[i] = entier;*/
                // OU plus directement : int.TryParse(Console.ReadLine(), out int tableau1b[i]);
                // AMELIORATION pour éviter les erreurs :
                do
                {
                    Console.WriteLine($"Introduire l'entier numéro {i + 1}");
                } while (!int.TryParse(Console.ReadLine(), out tableau1b[i]));
            }
            for (int j = 0; j < tableau1b.Length; j++)
            {
                Console.WriteLine(tableau1b[j]);
            }
        } //tableau encodage entier

        static void Tableau2() //double entier
        {   /*2. BONUS : initialiser un tableau de 10 entiers avec les valeurs 2, 4, 8, 16, 32, 64, 128, 256, 512,
        1024 à l’ aide d’une boucle. Ensuite, à l’ aide d’une boucle afficher la valeur de chaque cellule
        du tableau avec l’ opération Ecrire().*/
            int[] tableau2 = new int[10];
            int j = 1;
            for (int i = 0; i < tableau2.Length; i++)
            {
                j = j * 2;
                tableau2[i] = j;
                Console.WriteLine(tableau2[i]);
            }
        }

        static void Tableau3() //joueurs
        {   /*3. Écrire un algorithme demandant à l’utilisateur le nombre de joueurs (max 10 joueurs).
        Ensuite, l’ algorithme doit demander à l’utilisateur le score de chaque joueur . Une fois ceci
        fini, il faut afficher la moyenne des scores. Faites de même en C#*/
            int nbreJoueur;
            do
            {
                Console.WriteLine("Combien de joueurs ? (max10)");
            } while (!int.TryParse(Console.ReadLine(), out nbreJoueur) || nbreJoueur <= 0 || nbreJoueur > 10);

            int[] tableau3 = new int[nbreJoueur];
            int score;
            int moyenneScore = 0;
            for (int i = 0; i < tableau3.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Introduire le score du joueur {i + 1}");
                } while (!int.TryParse(Console.ReadLine(), out score));
                tableau3[i] = score;
                moyenneScore = moyenneScore + tableau3[i];
            }

            Console.WriteLine($"La Moyenne des scores est de {(float)moyenneScore / tableau3.Length}");
        }

        static void Tableau4() //inversion Tableau
            { /*4. Inverser un tableau : soit un tableau T . Saisir ce tableau. 
           * Changer de place les éléments de ce tableau de façon à ce que le nouveau tableau soit une sorte de miroir de l'ancien et afficher le nouveau tableau.*/
                int[] tableau4 = new int[] { 1, 2, 3, 4, 5 };
                int[] tableau4reverse = new int[tableau4.Length];
                for (int i = 0; i < tableau4.Length; i++)
                {
                    tableau4reverse[i] = tableau4[tableau4.Length - i];
                }
                for (int j = 0; j < tableau4reverse.Length; j++)
                {
                    Console.WriteLine(tableau4reverse[j]);
                }
            }
        static void ExerciceInversionTableau()
            {
                int[] tableau = new int[] { 1, 2, 3, 4, 5, 6 };
                int[] miroir = new int[tableau.Length];
                int j = 0;
                for (int i = tableau.Length - 1; i >= 0; i--, j++)
                {
                    miroir[j] = tableau[i];
                }
                foreach (int value in tableau)
                {
                    Console.WriteLine(value);
                }
                foreach (int value in miroir)
                {
                    Console.WriteLine(value);
                }
            }
        #endregion 



            //Les variables
            //1. T rouvez une méthode permettant d’inverser le contenu de deux variables (du même type évidemment). Si A = 5 et B = 7, après ce traitement, A = 7 et B = 5.
            static void ExerciceVariables()
            {
                Console.WriteLine("Tapez un chiffre:?");
                string a = Console.ReadLine();
                Console.WriteLine("Tapez un autre chiffre:?");
                string b = Console.ReadLine();
                Console.WriteLine($"Variable a = {a} et Variable b = {b}!");
                string c = a;
                a = b;
                b = c;
                Console.WriteLine($"Renversé => Variable a = {a} et variable b = {b}!");
            }

            //Les opérateurs arithmétiques
            static void ExerciceOperateurs()
            {
                int A = 8 % 3;
                int B = 4 + A;
                int C = B * A;
                int D = (C - A) * B;
                int E = ((A + 7)) * (D / A) * 0;
                Console.WriteLine($"Variable A = {A} - Variable B = {B} - Variable C = {C} - Variable D = {D} - Variable E = {E}");


            }

            static void ExSecondes()
            {
                //DECLARATION
                int secondes, minutes, heures, jours;

                //QUESTION & CONVERSION
                Console.WriteLine("Combien de secondes devons-nous convertir ?");
                /*string strSecondes = Console.ReadLine();
                bool boolSecondes = int.TryParse(strSecondes, out secondes);*/
                // OU en plus rapide -> 
                int.TryParse(Console.ReadLine(), out int convertSecondes);

                //CALCUL ET ASSIGNATION
                minutes = convertSecondes / 60; //465000/60=7750
                heures = minutes / 60; //7750/60=129
                jours = heures / 24; //129/24=5
                heures %= 24;
                // -> quand pointiller = possibilité améliorer -> CTRL + ; pour voir proposition d'amélioration
                minutes %= 60;
                secondes = convertSecondes % 60;

                //RESULTAT
                Console.WriteLine($"{convertSecondes} secondes = {jours} jour(s); {heures} heure(s); {minutes} minute(s); {secondes} seconde(s)");

            }

            static void CorrectionConvertisseurSecondes()
            {
                int TotalSecondes = 456100; //4561
                int secondes, minutes, heures, jours;
                secondes = TotalSecondes % 60;
                //Console.WriteLine($"Secondes : {secondes}");
                minutes = TotalSecondes / 60;
                //Console.WriteLine($"Minutes : {minutes}");
                heures = minutes / 60;
                //Console.WriteLine($"Heures : {heures}");
                minutes %= 60;
                //Console.WriteLine($"Minutes : {minutes}");
                jours = heures / 24;
                //Console.WriteLine($"Jours : {jours}");
                heures %= 24;
                //Console.WriteLine($"Heures : {heures}");
                Console.WriteLine($"{jours} jours {heures} heures {minutes} minutes {secondes} secondes");
            }

            static void Conversion()
            {

                //QUESTION + CONVERSION
                Console.WriteLine("Encodez un nombre : ");
                int.TryParse(Console.ReadLine(), out int nb1);
                Console.WriteLine("Encodez un autre nombre : ");
                int.TryParse(Console.ReadLine(), out int nb2);

                //RESULTAT
                Console.WriteLine($"L'addition de {nb1} et {nb2} vaut {nb1 + nb2}");
                Console.WriteLine($"La divison de {nb1} par {nb2} vaut {(float)nb1 / nb2}");


            }

            static void ConditionsBissextile()
            {

                Console.WriteLine("Année : ");
                if (int.TryParse(Console.ReadLine(), out int annee))
                {
                    if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
                    {
                        Console.WriteLine($"L'année {annee} est une année bissextile");
                    }
                    else
                    {
                        Console.WriteLine($"L'année {annee} n'est pas une année bissextile");
                    }
                }
                else
                {
                    Console.WriteLine("Ceci n'est pas valide.");
                }


            }

            static void ConditionsTennis()
            {
                // 2. Lanceur de balles de tennis (Pseudo-Code)
                /*Réaliser l’ algorithme d’un lanceur de balles de tennis. Ce lanceur possède deux états:
                ● prêt: permet de savoir si le tennisman est prêt. Il ne faut pas lancer de balles dans le cas contraire
                ● panierVide: permet de savoir s’il y a encore des balles disponibles 
                Le lanceur de balle possède l’ opération « lancerBalle » qui, vous l’ aurez compris, permet de lancer une balle.*/

                Console.WriteLine("Êtes-vous prêt à jouer ? \n\t 1 - OUI je suis prêt à jouer \n\t 2 - NON je ne veux pas jouer");
                int.TryParse(Console.ReadLine(), out int Play);
                Console.WriteLine("Est-ce qu'il reste des balles ? (Y) Yes - (N) No");
                string basket = Console.ReadLine();
                int nbreBalles = 10;
                if (Play == 1 && basket == "Y")
                {
                    if (nbreBalles > 0)
                    {
                        Console.WriteLine("BALLES !!!");
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus de balles dans le panier...");
                    }
                }
                else
                {
                    Console.WriteLine("WAIT...");
                }

            }

            static void ConditionsBoissons()
            { /*            3. Distributeur de boissons(Pseudo-Code)
                Réaliser l’ algorithme d’un distributeur de boissons. Ce dernier propose plusieurs boissons et
                l’utilisateur choisit celle qu’il désire en entrant le numéro correspondant.Ne pas oublier pas de
                vérifier s’il y a encore des boissons en stock.
                    */
                int quantiteCoca = 3, qFanta = 2, qCecemel = 0, qJus = 10, qMojito = 1;

                Console.WriteLine("Quelle boisson désirez vous ?\n" +
                    $"\t 1 - Coca ({quantiteCoca})\n" +
                    $"\t 2 - Fanta ({qFanta})\n" +
                    $"\t 3 - Cécémel ({qCecemel})\n" +
                    $"\t 4 - Jus de Pomme ({qJus}) \n" +
                    $"\t 5 - Mojito ({qMojito})");
                // PAS BESOIN DU INT vu qu'il n'y a pas de calcul mais du coup besoin de "" pour les case
                int.TryParse(Console.ReadLine(), out int boisson);
                //string boisson = Console.ReadLine();
                Console.WriteLine("Est-ce qu'il en reste ? Y/N");
                string quantite = Console.ReadLine();
                if (quantite == "Y" || quantite == "y")
                {
                    switch (boisson)
                    {
                        case 1:
                            if (quantiteCoca > 0)
                            {
                                Console.WriteLine("Voici votre Coca");
                            }
                            else
                            {
                                Console.WriteLine("Désolé, il n'y a plus de Coca...");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Voici votre Fanta");
                            break;
                        case 3:
                            Console.WriteLine("Voici votre Cécémel");
                            break;
                        case 4:
                            Console.WriteLine("Voici votre Jus de Pomme");
                            break;
                        case 5:
                            Console.WriteLine("Voici votre Mojito");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Il n'y a plus de cette boisson");
                }

            }

            static void ConditionsCalculatrice()
            {   /*4.Calculatrice(Pseudo - Code + C#)
Réaliser l’ algorithme d’une calculatrice basique.L ’utilisateur est invité à saisir un nombre, un
opérateur, et un deuxième nombre.La calculatrice affiche ensuite le résultat.
        */
                Console.WriteLine("Nombre 1 : ");
                int.TryParse(Console.ReadLine(), out int nbre1);
                Console.WriteLine("Quelle opération souhaitez-vous faire ?\n" +
                    "\t +   Addition\n" +
                    "\t -   Soustraction\n" +
                    "\t /   Division\n" +
                    "\t *   Multiplication\n " +
                    "\t %   Modulo");
                string Operateur = Console.ReadLine();
                Console.WriteLine("Nombre 2 : ");
                int.TryParse(Console.ReadLine(), out int nbre2);
                switch (Operateur)
                {
                    case "+":
                        Console.WriteLine($"{nbre1} {Operateur} {nbre2} = {(float)nbre1 + nbre2}");
                        break;
                    case "-":
                        Console.WriteLine($"{nbre1} {Operateur} {nbre2} = {(float)nbre1 - nbre2}");
                        break;
                    case "/":
                        Console.WriteLine($"{nbre1} {Operateur} {nbre2} = {(float)nbre1 / nbre2}");
                        break;
                    case "*":
                        Console.WriteLine($"{nbre1} {Operateur} {nbre2} = {(float)nbre1 * nbre2}");
                        break;
                    case "%":
                        Console.WriteLine($"{nbre1} {Operateur} {nbre2} = {(float)nbre1 % nbre2}");
                        break;
                }
            }

            static void ConditionsDurees()
            {/*            5.Différence entre deux durées
  À l'aide de l'algorithme convertisseur de seconde, réaliser un algorithme faisant la différence entre
deux durées(exprimées en jours, heures, minutes, secondes)*/

                Console.WriteLine("\tPremière durée : \n" +
                    "Nombre de jour(s) : ");
                int.TryParse(Console.ReadLine(), out int jour1);
                Console.WriteLine("Nombre d'heure(s) : ");
                int.TryParse(Console.ReadLine(), out int heure1);
                Console.WriteLine("Nombre de minute(s) : ");
                int.TryParse(Console.ReadLine(), out int minute1);
                Console.WriteLine("Nombre de seconde(s) : ");
                int.TryParse(Console.ReadLine(), out int seconde1);

                int TotSeconde1 = (((jour1 * 24) + heure1) * 60 + minute1) * 60 + seconde1;

                Console.WriteLine($"Première durée = {jour1} jour(s), {heure1} heure(s), {minute1} minute(s) et {seconde1} seconde(s)");
                Console.WriteLine($"Ce qui fait au total {TotSeconde1} secondes");


                Console.WriteLine("\n\tDeuxième durée : \n" +
                   "Nombre de jour(s) : ");
                int.TryParse(Console.ReadLine(), out int jour2);
                Console.WriteLine("Nombre d'heure(s) : ");
                int.TryParse(Console.ReadLine(), out int heure2);
                Console.WriteLine("Nombre de minute(s) : ");
                int.TryParse(Console.ReadLine(), out int minute2);
                Console.WriteLine("Nombre de seconde(s) : ");
                int.TryParse(Console.ReadLine(), out int seconde2);

                int TotSeconde2 = (((jour2 * 24) + heure2) * 60 + minute2) * 60 + seconde2;
                Console.WriteLine($"Deuxième durée = {jour2} jour(s), {heure2} heure(s), {minute2} minute(s) et {seconde2} seconde(s)");
                Console.WriteLine($"Ce qui fait au total {TotSeconde2} secondes");

                int DifferenceDuree = TotSeconde1 - TotSeconde2;

                int minutes = DifferenceDuree / 60;
                int heures = minutes / 60;
                int jours = heures / 24;
                heures %= 24;
                minutes %= 60;
                int secondes = DifferenceDuree % 60;

                Console.WriteLine($"\nLa différence de durée est de {jours} jour(s), {heures} heure(s), {minutes} minute(s) et {secondes} seconde(s)");
            }

            static void ConditionsPaire()
            { /*Demander à l’utilisateur d’encoder 1 nombre(int), si la somme des deux moitiés de celui-ci donne le nombre, afficher « le nombre est paire » 
                sinon « le nombre est impaire »*/
                Console.WriteLine("Indiquez un nombre : ");
                int.TryParse(Console.ReadLine(), out int nombre);
                if (((nombre / 2) * 2) == nombre)
                {
                    Console.WriteLine($"{nombre} est un nombre pair");
                }
                else
                {
                    Console.WriteLine($"{nombre} est un nombre impair");
                }

            }

            static void CompteBanquaire()
            {

                Console.WriteLine("Introduisez votre BBAN (12 chiffres sans espace ni tiret :");
                string compteBanque = Console.ReadLine();

                string debut = compteBanque.Substring(0, 10);
                int.TryParse(debut, out int debutInt);
                string fin = compteBanque.Substring(10);
                int.TryParse(fin, out int finInt);

                if ((finInt == 97 && debutInt % 97 == 0) || debutInt % 97 == finInt)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("KO");
                }


            }

            static void BoucleTable()
            {  /*1. À l’ aide d’une boucle, afficher la table de multiplication par 2. Ensuite, coder votre algorithme en C#.*/
                Console.WriteLine("Quelle table de multiplication souhaitez-vous voir ?");
                int.TryParse(Console.ReadLine(), out int table);

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {table} = {i * table}");
                }

            }

            static void LanceurBalle()
            {
                string Play;
                int nbreBalles = 6;
                do
                {
                    Console.WriteLine("Êtes-vous prête à jouer ? " +
                        "\n\t 1 - OUI je suis prête à jouer " +
                        "\n\t 2 - ATTENDS je ne suis pas prête " +
                        "\n\t 3 - NON je ne veux pas jouer");
                    Play = Console.ReadLine();
                    switch (Play)
                    {
                        case "1":
                            while (nbreBalles > 0)
                            {
                                nbreBalles--;
                                Console.WriteLine($"BALLES !!! \n il reste {nbreBalles} balles");
                            }
                            Console.WriteLine("Veuillez remettre des balles dans le panier...");
                            Console.WriteLine("Combien de balle(s) voulez-vous remettre dans le panier ?");
                            int.TryParse(Console.ReadLine(), out nbreBalles);
                            break;
                        case "2":
                            Console.WriteLine("WAIT...");
                            break;

                    }
                } while (Play != "3");
            }

            static void DoubleMultiplication()
            {  /*3. À l’ aide de deux boucles, afficher les tables de multiplication de 1 à 9. Ensuite, coder votre algorithme en C#.*/

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"\nTable de {i}");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{j} x {i} = {j * i}");
                    }
                }
        }

            static void Etoile()
            { /*6. Réalisez un algorithme qui demande un nombre à l'utilisateur et affiche autant de ligne que le nombre spécifié par l'utilisateur .*/
                Console.WriteLine("Combien de ligne(s) souhaitez-vous afficher ?");
                int.TryParse(Console.ReadLine(), out int lignes);
                string etoile = "*";
                for (int i = 1; i <= lignes; i++)
                {
                    Console.WriteLine(i + ". " + etoile);
                    etoile += "*";
                }
            }

            static void BoucleBoissons()
            {
                int quantiteCoca = 3, qFanta = 2, qCecemel = 0, qJus = 10, qMojito = 1, boisson;

                do
                {
                    Console.WriteLine("Quelle boisson désirez vous ?\n" +
                    $"\t 1 - Coca ({quantiteCoca})\n" +
                    $"\t 2 - Fanta ({qFanta})\n" +
                    $"\t 3 - Cécémel ({qCecemel})\n" +
                    $"\t 4 - Jus de Pomme ({qJus}) \n" +
                    $"\t 5 - Mojito ({qMojito})\n" +
                    $"\t 6 - RIEN je n'ai pas soif");
                    int.TryParse(Console.ReadLine(), out boisson);

                    switch (boisson)
                    {
                        case 1:
                            if (quantiteCoca > 0)
                            {
                                Console.WriteLine("Voici votre Coca");
                                quantiteCoca--;
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a plus de Coca");
                            }
                            break;
                        case 2:
                            if (qFanta > 0)
                            {
                                Console.WriteLine("Voici votre Fanta");
                                qFanta--;
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a plus de Fanta");
                            }
                            break;
                        case 3:
                            if (qCecemel > 0)
                            {
                                Console.WriteLine("Voici votre Cécémel");
                                qCecemel--;
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a plus de Cécémel");
                            }
                            break;
                        case 4:
                            if (qJus > 0)
                            {
                                Console.WriteLine("Voici votre Jus");
                                qJus--;
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a plus de Jus");
                            }
                            break;
                        case 5:
                            if (qMojito > 0)
                            {
                                Console.WriteLine("Voici votre Mojito");
                                qMojito--;
                            }
                            else
                            {
                                Console.WriteLine("Il n'y a plus de Mojito");
                            }
                            break;
                    }
                } while (boisson != 6);
                Console.WriteLine("Merci aurevoir.");
            }

            static void BoucleMotDePasse()
            {/*5. Réalisez un système de connexion à l'aide d'un mot de passe. L'algorithme demande à
                l'utilisateur de saisir son mot de passe. Si ce dernier valide de bon mot de passe, on le salue.
                Par contre, si il fait une erreur trois fois de suite, un message lui signalera que son compte est
                bloqué et il ne pourra pas réessayer une quatrième fois*/
                string motDePasse, reponse = "m0td3pa553";
                int essai = 3;
                do
                {
                    Console.WriteLine("Quel est le Mot de Passe ?");
                    motDePasse = Console.ReadLine();
                    if (motDePasse == reponse)
                    {
                        Console.WriteLine("Bravo et bienvenue au pays de bisounours.");
                    }
                    else
                    {
                        essai--;
                        Console.WriteLine($"Ceci n'est pas le bon mot de passe... il vous reste {essai} essais.");
                    }

                } while (essai > 0 && motDePasse != reponse);
                if (essai == 0)
                {
                    Console.WriteLine("Votre compte est bloqué !");
                }


            }
        
    }
}
