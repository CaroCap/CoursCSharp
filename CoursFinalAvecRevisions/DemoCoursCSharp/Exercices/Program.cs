using System;
using System.Collections.Generic;

namespace Exercices
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // ExerciceVariables();
            // ExerciceOperateurs();
            // ConvertisseurSecondes();
            // Conversions();
            // ExerciceAnneeBissextile();
            // ExerciceLanceurDeBalle();
            // ExerciceDistributeur();
            // ExerciceCalculatrice();
            // ExerciceDifferenceDates();
            // ExerciceNombrePair();
            //ExerciceValidationBBAN();
            //ExerciceTableMultiplication2();
            //ExerciceLanceurBallesV2();
            //ExerciceTableMultiplication1_9();
            //ExerciceDemiSapin();
            //ExerciceInsertionTableau();
            //ExerciceMoyenneScores();
            //ExerciceInversionTableau();
            //ExerciceDeplacementPion();
            //ExerciceBulletin();
            ExerciceCalculEcrit();
        }

        /**
         * Demander à l'utilisateur de rentrer deux données 
         * à stocker dans 2 variables A et B
         * Afficher leur contenu
         * Inverser les valeurs contenues dans les 2 variables
         * Afficher les variables mise à jours
         */
        static void ExerciceVariables()
        {
            Console.WriteLine("Entrez une valeur pour A !");
            string A = Console.ReadLine();
          
            
            Console.WriteLine("Entrez une valeur pour B !");
            string B = Console.ReadLine();

            Console.WriteLine($"A vaut {A} - B vaut {B}");
            string Temp = A;
            
            A = B;
            B = Temp;

            Console.WriteLine("Après permutation");
            Console.WriteLine($"A vaut {A} - B vaut {B}");

        }
        
        static void ExerciceOperateurs()
        {
            // Déclarations
            int A, B, C, D, E;
            
            // Affectations
            A = 8 % 3;
            B = 4 + A;
            C = B * A;
            D = (C - A) * B;
            E = ((A + 7) * (D / A)) * 0;

            // Affichage
            Console.WriteLine(
                $"\tA vaut {A, 3:C}" + // Donne 3 "espaces" pour aligner l'affichage
                $"\nB vaut {B}" +
                $"\nC vaut {C}" +
                $"\nD vaut {D}" +
                $"\nE vaut {E}"
                );


        }

        static void ConvertisseurSecondes()
        {
            Console.WriteLine("Entrez le nombre de secondes à convertir :");
          //  string input = Console.ReadLine();
            int TotalSecondes = 4561; //4561
        //  int.TryParse(input, out TotalSecondes);
            bool b = int.TryParse(Console.ReadLine(), out TotalSecondes);
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

        /**
         * Exercice Conversions
         * 
         * En utilisant la méthode «Console.ReadLine()»
         * Demander à l’utilisateur d’encoder 2 nombres (int)
         * et d’en faire l’addition et la division REELLE de ces 2 nombres
         * la conversion devra utiliser la méthode «int.TryParse()»
         * 
         * Résultat = L'addition de 5 par 3 vaut 8
         *            La division de 5 par 3 vaut 1.6666666
         * 
         */

        static void Conversions()
        {
            Console.WriteLine("Entrez un premier nombre entier !");
            int.TryParse(Console.ReadLine(), out int A);
            Console.WriteLine("Entrez un deuxième nombre entier !");
            int.TryParse(Console.ReadLine(), out int B);

            Console.WriteLine($"L'addition de {A} par {B} vaut {A + B}" +
                $"\nLa division de {A} par {B} vaut {(double)A / B}");

        }

        static void ExerciceAnneeBissextile()
        {
            Console.WriteLine("Entrez une année pour la vérification !");
            if (int.TryParse(Console.ReadLine(), out int annee))
            {
                // Continuer l'exécution du code
                if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
                {
                    Console.WriteLine($"{annee} est bissextile");
                }
                else
                {
                    Console.WriteLine($"{annee} n'est pas bissextile");
                }

                //if (annee % 400 == 0)
                //{
                //    Console.WriteLine("OK");
                //} else if (annee % 4 == 0)
                //{
                //    if (annee % 100 != 0)
                //    {
                //        Console.WriteLine("OK");
                //    } else
                //    {
                //        Console.WriteLine("KO");
                //    }
                //} else
                //{
                //    Console.WriteLine("KO");
                //}

                if (annee % 4 == 0)
                {
                    if (annee % 100 != 0)
                    {
                        // ok
                        Console.WriteLine($"{annee} est bissextile");
                    } 
                }
                else if (annee % 400 == 0)
                {
                    // ok
                    Console.WriteLine($"{annee} est bissextile");
                }
                else
                {
                    // pas ok
                    Console.WriteLine($"{annee} n'est pas bissextile");
                }

            } else
            {
                // Problème de conversion
                Console.WriteLine("Désolé, je n'ai pas pu convertir ta donnée en entier");
            }

            // Approche non représentative de la ligne 124
            if (annee % 4 == 0)
            {
                if (annee % 100 != 0)
                {
                    //ok

                } else if (annee % 400 == 0)
                {
                    //OK
                } else
                {
                    // pas ok
                }
            }

            // Approche identique à la combinaison de conditions de la ligne 124
            //if (annee % 4 == 0)
            //{
            //    if (annee % 100 != 0)
            //    {
            //        //ok

            //    } else if (annee % 400 == 0)
            //    {

            //    } else
            //    {
            //        // pas ok
            //    }
            //} else if (annee % 400 == 0)
            //{
            //    // ok
            //} else
            //{
            //    // pas ok
            //}

            //
            if (annee % 4 == 0)
            {
                if (annee % 100 != 0)
                {
                    // ok
                }
            } else if (annee % 400 == 0)
            {
                // ok
            }
            else
            {
                // pas ok
            }
        }

        static void ExerciceLanceurDeBalle() 
        {
            int nbBallesDansPanier = 0;
            Console.WriteLine("Etes-vous prêt à recevoir une balle (o/n)");
            string pret = Console.ReadLine();

            if (pret == "o")
            {
                if (nbBallesDansPanier > 0)
                {
                    Console.WriteLine("J'envoie une nouvelle balle !!!");
                } else
                {
                    Console.WriteLine("Désolé, le panier à balles est vide !");
                }
            } else
            {
                Console.WriteLine("Réessayez quand vous serez prêt !!!");
            }

        }

        static void ExerciceDistributeur()
        {
            int qCoca = 5, qFanta = 2, qEau = 0;
            
            Console.WriteLine("Entrez le n° d'une boisson");
            Console.WriteLine("\t1. Coca\n\t2. Fanta\n\t3. Eau");

            string numeroBoisson = Console.ReadLine();

            switch (numeroBoisson)
            {
                case "1":
                    if (qCoca > 0)
                    {
                        Console.WriteLine("Voici un coca bien frais");
                        Console.WriteLine("Stock restant " + (qCoca - 1));
                    } else
                    {
                        Console.WriteLine("Désolé, il n'y pas plus de coca");
                    }
                    break;
                case "2":
                    if (qFanta > 0)
                    {
                        Console.WriteLine("Voici un fanta bien frais");
                    }
                    else
                    {
                        Console.WriteLine("Désolé, il n'y pas plus de fanta");
                    }
                    break;
                case "3":
                    if (qEau > 0)
                    {
                        Console.WriteLine("Voici un eau bien fraîche");
                    }
                    else
                    {
                        Console.WriteLine("Désolé, il n'y pas plus d'eau");
                    }
                    break;
                default:
                    Console.WriteLine("Erreur, la boisson souhaitée n'existe pas !!!");
                    break;
            }
        }

        static void ExerciceCalculatrice()
        {
            // Entrées des différentes données pour mon programme
            Console.WriteLine("Entrez le premier nombre :");
            int.TryParse(Console.ReadLine(), out int NB1);

            Console.WriteLine("Entrez l'opérateur souhaité (+,-,*,/,%)");
            string operateur = Console.ReadLine();

            Console.WriteLine("Entrez le deuxième nombre :");
            int.TryParse(Console.ReadLine(), out int NB2);


            // Manipulation des données
            switch (operateur)
            {
                case "+":
                    Console.WriteLine($"{NB1} + {NB2} = {NB1 + NB2}");
                    break;
                case "-":
                    Console.WriteLine($"{NB1} - {NB2} = {NB1 - NB2}");
                    break;
                case "*":
                    Console.WriteLine($"{NB1} * {NB2} = {NB1 * NB2}");
                    break;
                case "/":
                    Console.WriteLine($"{NB1} / {NB2} = {NB1 / NB2}");
                    break;
                case "%":
                    Console.WriteLine($"{NB1} % {NB2} = {NB1 % NB2}");
                    break;
                default:
                    Console.WriteLine("L'opérateur n'est pas reconnu !!!");
                    break;
            }
        }

        static void ExerciceDifferenceDates()
        {
            Console.WriteLine("Entrez le jour de la date 1");
            int.TryParse(Console.ReadLine(), out int jD1);
            Console.WriteLine("Entrez l'heure de la date 1");
            int.TryParse(Console.ReadLine(), out int hD1);
            Console.WriteLine("Entrez les minutes de la date 1");
            int.TryParse(Console.ReadLine(), out int mD1);
            Console.WriteLine("Entrez les secondes de la date 1");
            int.TryParse(Console.ReadLine(), out int sD1);

            Console.WriteLine("Entrez le jour de la date 2");
            int.TryParse(Console.ReadLine(), out int jD2);
            Console.WriteLine("Entrez l'heure de la date 2");
            int.TryParse(Console.ReadLine(), out int hD2);
            Console.WriteLine("Entrez les minutes de la date 2");
            int.TryParse(Console.ReadLine(), out int mD2);
            Console.WriteLine("Entrez les secondes de la date 2");
            int.TryParse(Console.ReadLine(), out int sD2);

            // Tout transformer en secondes
            int totalSecondesDate1 = (jD1 * 86400) + (hD1 * 3600) + (mD1 * 60) + sD1;
            int totalSecondesDate2 = (jD2 * 86400) + (hD2 * 3600) + (mD2 * 60) + sD2;

            //Console.WriteLine(totalSecondesDate1 + "\n" + totalSecondesDate2);

            // Valeur absolue de la différence
            int differenceDates = Math.Abs(totalSecondesDate1 - totalSecondesDate2);

            int secondes, minutes, heures, jours;

            secondes = differenceDates % 60;
            //Console.WriteLine($"Secondes : {secondes}");
            minutes = differenceDates / 60;
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

        static void ExerciceNombrePair()
        {
            Console.WriteLine("Entrez un nombre entier");
            int.TryParse(Console.ReadLine(), out int nb);

            if (nb/2 + nb/2 == nb)
            {
                Console.WriteLine($"le nombre {nb} est pair");
            } else
            {
                Console.WriteLine($"le nombre {nb} est impair");
            }
        }

        static void ExerciceValidationBBAN()
        {
            // Introduction de la donnée
            Console.WriteLine("Entrez un numéro à 12 chiffres pour valider un BBAN");
            string bban = Console.ReadLine();

            // Préparation des données pour la validation
            string bban_10 = bban.Substring(0, 10);
            string bban_2 = bban.Substring(10);

            // Convertion des données en type numérique
            if (long.TryParse(bban_10, out long bban10))
            {
                if (int.TryParse(bban_2, out int bban2))
                {
                    // VALIDER MON BBAN
                    if (bban10 % 97 == bban2)
                    {
                        Console.WriteLine("BBAN Valide [OK]");
                    } else if (bban10 % 97 == 0 && bban2 == 97)
                    {
                        Console.WriteLine("BBAN Valide [OK]");
                    } else
                    {
                        Console.WriteLine("BBAN Invalide [KO]");
                    }
                }
                else
                {
                    Console.WriteLine("Attention, votre bban n'est pas valide");
                }
            }
            else
            {
                Console.WriteLine("Attention, votre bban n'est pas valide");
            }

            //if (int.TryParse(bban_10, out int bban10) && int.TryParse(bban_2, out int bban2))
            //{

            //} else
            //{
            //    Console.WriteLine("Attention, votre bban n'est pas valide");
            //}
        }

        static void ExerciceTableMultiplication2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"2 X {i} = {2 * i}");
            }
        }

        static void ExerciceLanceurBallesV2()
        {
            int nbBallesDansPanier = 10;
            string pret;
            do
            {
                Console.WriteLine("Etes-vous prêt à recevoir une balle (o/n)");
                pret = Console.ReadLine();

                if (pret == "o")
                {
                    while (nbBallesDansPanier > 0)
                    {
                        Console.WriteLine("J'envoie une nouvelle balle !!!");
                        nbBallesDansPanier--;
                    }

                    Console.WriteLine("Vous n'avez plus de balles, fin de partie.");

                }
                else
                {
                    Console.WriteLine("Réessayez quand vous serez prêt !!!");
                }
            } while (pret != "o");

            Console.WriteLine("Au revoir");
            
        }

        static void ExerciceTableMultiplication1_9()
        {
            for (int nombre = 1; nombre <= 9; nombre++)
            {
                for (int multiplicateur = 1; multiplicateur <= 10; multiplicateur++)
                {
                    Console.Write($"{nombre}X{multiplicateur}={nombre * multiplicateur}\t");
                }
                Console.WriteLine();
            }
        }

        static void ExerciceDemiSapin()
        {
            Console.WriteLine("Entrez le nombre de ligne à afficher");
            int.TryParse(Console.ReadLine(), out int lignes);
            string demiSapin = "*";
            int compteur = 0;
            while(compteur < lignes)
            {
                Console.WriteLine(demiSapin);
                demiSapin += "*";
                compteur++;
            }

            //
            for (int i = 0; i < lignes; i++)
            {
                Console.WriteLine(demiSapin);
                demiSapin += "*";
            }

        }

        static void ExercicePlusOuMoins()
        {
            Random random = new Random();
            int nbATrouver = random.Next(1, 101);
        }

        static void ExerciceInsertionTableau()
        {
            int[] tableau = new int[6];
            
            // Saisie par l'utilisateur
            for (int i = 0; i < tableau.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Veuillez entrer la valeur de l'entier {i + 1}");
                
                } while (!int.TryParse(Console.ReadLine(), out tableau[i]));
                
            }

            // Affichage
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }

        static void ExerciceMoyenneScores()
        {
            int nombreJoueur, totalScore = 0;
            
            do
            {
                Console.WriteLine("Entrez le nombre de joueurs ( max 10 )");
            } while (!int.TryParse(Console.ReadLine(), out nombreJoueur) || nombreJoueur <= 0 || nombreJoueur > 10);

            int[] scores = new int[nombreJoueur];

            for (int i = 0; i < scores.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Entrez le score du joueur {i + 1}");
                } while (!int.TryParse(Console.ReadLine(), out scores[i]));
                
                totalScore += scores[i];
            }

            Console.WriteLine($"La moyenne des scores vaut {(float)totalScore / nombreJoueur}");

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

        static void ExerciceDeplacementPion()
        {
            int[] tableau = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int indexDuPion = 0;
            ConsoleKeyInfo touche;
            do
            {
                Console.WriteLine("Appuyez sur g pour déplacer le pion à gauche");
                Console.WriteLine("Appuyez sur d pour déplacer le pion à droite");
                Console.WriteLine("Appuyez sur q pour quitter");
                touche = Console.ReadKey();
                /**
                // Approche IF
                if (touche.Key == ConsoleKey.G)
                {
                    // Logique de déplacement à gauche
                } else if (touche.Key == ConsoleKey.D)
                {
                    // Logique de déplacement à droite
                }
                */
                // Approche SWITCH
                switch (touche.Key)
                {
                    case ConsoleKey.G:
                        // Logique de déplacement à gauche
                        if (indexDuPion > 0)
                        {
                            tableau[indexDuPion] = 0;
                            indexDuPion--;
                            tableau[indexDuPion] = 1;
                        }
                        break;
                    case ConsoleKey.D:
                        // Logique de déplacement à droite
                        if (indexDuPion < tableau.Length - 1) // 9
                        {
                            tableau[indexDuPion] = 0;
                            indexDuPion++;
                            tableau[indexDuPion] = 1;
                        }
                        break;
                    default:
                        Console.WriteLine("La touche n'est pas reconnue");
                        break;
                }

                for (int i = 0; i < tableau.Length; i++)
                {
                    Console.Write(tableau[i] + "\t");
                }
                Console.WriteLine();


            } while (touche.Key != ConsoleKey.Q);
            Console.WriteLine("Au revoir");
        }

        /**
         * Créer le bulletin de l'année d'une classe de 5 élèves
         * Le bulletin va être contenu dans un Dictionnaire où la clé est le nom de l'élève
         * et la valeur est l'ensemble des côtes de l'année de l'élève.
         * Afficher l'ensemble des données (Nom + côtes) de tous les élèves et
         * calculer la moyenne de chaque élève (à juste afficher)
         */

        static void test()
        {
            int[] tab = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            
        }

        static void ExerciceBulletin()
        {
            static double Moyenne(int[] cotes)
            {
                int sommeValeurs = 0;
                for (int i = 0; i < cotes.Length; i++)
                {
                    // sommeValeurs = sommeValeurs + cotes[i]
                    sommeValeurs += cotes[i];
                }

                return (double)sommeValeurs / cotes.Length;
            }

            const int NB_ELEVE = 5;
            //<string, List<int>>
            Dictionary<string, int[]> bulletin = new Dictionary<string, int[]>();

            // Acquisitions des données des élèves
            for (int i = 0; i < NB_ELEVE; i++)
            {
                Console.WriteLine("Entrez le nom de l'élève");
                string nom = Console.ReadLine();
                int nbCotes;
                do
                {
                    Console.WriteLine("Entrez le nombre de côtes à insérer");
                } while (!int.TryParse(Console.ReadLine(), out nbCotes));

                int[] cotes = new int[nbCotes];

                for (int j = 0; j < cotes.Length; j++)
                {
                    do
                    {
                        Console.WriteLine($"Entrez la côte {j + 1}");
                    } while (!int.TryParse(Console.ReadLine(), out cotes[j]));

                }

                bulletin.Add(nom, cotes);
            }

            // Affichage du bulletin
            foreach (KeyValuePair<string, int[]> eleve in bulletin)
            {
                Console.Write($"{eleve.Key}\t");
                Console.Write("[");
                int compteur = 0;
                foreach (int valeur in eleve.Value)
                {
                    if (compteur < eleve.Value.Length - 1) Console.Write($"{valeur},");
                    else Console.Write($"{valeur}");
                    compteur++;
                }
                Console.WriteLine($"]\tMoyenne {Moyenne(eleve.Value)}");
               
                
            }

        }

        /**
         * Demandez à l’utilisateur d’introduire deux nombres au clavier 
         * et faite l’addition de ces deux nombres en ne convertissant 
         * que ca ractère par caractère. 
         * (Méthode « ToCharArray » de la classe « string »).
         */

        // String nb1 = Console.ReadLine();
        // char[] nb1Cars = nb1.ToCharArray();

        //       145        15
        //   +   286       +09 
        //  ________      ____
        //       431
        public static void ExerciceCalculEcrit()
        {
            Console.WriteLine("Entrez un premier nombre entier");
            string nb1 = Console.ReadLine();

            Console.WriteLine("Entrez un deuxième nombre entier");
            string nb2 = Console.ReadLine();

            char[] tabNb1 = nb1.ToCharArray();
            char[] tabNb2 = nb2.ToCharArray();

            int tailleDuPlusGrandTableau;

            // IDENTIQUE A L APPEL DU TERNAIRE
            //if (tabNb1.Length > tabNb2.Length)
            //{
            //    tailleDuPlusGrandTableau = tabNb1.Length;
            //} else
            //{
            //    tailleDuPlusGrandTableau = tabNb2.Length;
            //}
            //
            // Operateur ternaire => affectation conditionnelle
            //  CONDITION  ?  VALEUR POUR VRAI  :  VALEUR POUR FAUX
            tailleDuPlusGrandTableau = (tabNb1.Length > tabNb2.Length) ? tabNb1.Length : tabNb2.Length;

            // Créer un nouveau tableau de taille TailleDuPlusGrandTableau qui va contenir
            // les données du plus petit tableau en plus des zéros pour le remplir

            char[] nouveauTab = new char[tailleDuPlusGrandTableau];

            char[] petitTabTemp = (tabNb1.Length > tabNb2.Length) ? tabNb1 : tabNb2;

            
            int deltaTableauLength = Math.Abs(tabNb1.Length - tabNb2.Length);

            for (int i = 0; i < petitTabTemp.Length - 1; i++)
            {
                nouveauTab[deltaTableauLength + i] = petitTabTemp[i];
            }

            for (int i = 0; i < nouveauTab.Length; i++)
            {
                if (i > deltaTableauLength)
                {
                    nouveauTab[i] = '0';
                }
            }

            foreach (char item in nouveauTab)
            {
                Console.Write(item);
            }
        }

        /**
         * Gestion d'une bibliothèque
         * Créer une structure qui va définir un livre
         * La structure Livre se compose :
         * - du titre du livre
         * - son auteur
         * - les chapitres (Dictionary<string, string> Clé = Titre du chapitre, Valeur = Contenu)
         * - d'une fonction qui va afficher les différentes informations du livre
         * Créer une liste de livre et afficher l'ensemble de la liste
         */
       
    }
}
