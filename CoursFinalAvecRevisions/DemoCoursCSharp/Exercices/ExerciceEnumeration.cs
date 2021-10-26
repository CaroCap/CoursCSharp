using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class ExerciceEnumeration
    {
        /** Enumeration listant les différents postes d'une entreprise
         */
        public enum Poste
        {
            Directrice = 10,
            Assistante = 5,
            Secretaire = 2,
            Employée = 1
        }

        public struct Personnel
        {
            public string Nom;
            public Poste fonction;
        }

        static void Main(string[] args)
        {
            //Personnel membre1;
            //membre1.Nom = "Caroline";
            //membre1.fonction = Poste.Directrice;

            //Personnel membre2;
            //membre2.Nom = "Ceuleers";
            //membre2.fonction = Poste.Employée | Poste.Secretaire;

            //if ((int)membre2.fonction < 5)
            //{
            //    Console.WriteLine("Je n'ai pas beaucoup de pouvoir de décision dans la société");
            //} else
            //{
            //    Console.WriteLine("Je fais partie du staff dirigeant");
            //}

            MagasinDeVetements();
        }

        /**
         * Exercice d'un magasin de vetements type E-Shop
         * 
         * Décrire un vetement (structure) comme suit :
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
         *  que l'on souhaite acheter
         *  
         */
        public enum MatiereVetement
        {
            Cuir,
            Tissu,
            Lin,
            Synthétique,
            Soie
        }

        public enum CouleurVetement
        {
            Blanc,
            Noir,
            Vert,
            Rouge,
            Saumon
        }

        public enum TailleVetement
        {
            XS,
            S,
            M,
            L,
            XL,
            XXL
        }

        public enum TypeVetement
        {
            PANTALON,
            TSHIRT,
            ROBE,
            JUPE,
            VESTE,
            SHORT
        }

        public struct Vetement
        {
            public TypeVetement Type;
            public string Marque;
            public MatiereVetement Matiere;
            public CouleurVetement Couleur;
            public TailleVetement Taille;
            public double PrixHTVA;
            public int Quantite;

            public void Afficher()
            {
                Console.WriteLine($"Vêtement -----------------------");
                Console.WriteLine($"[{Type}]\t{Marque}");
                Console.WriteLine($"{Matiere}\t{Couleur}\t{Taille}");
                Console.WriteLine($"{PrixHTVA} EUR\t Quantité:{Quantite}");
                Console.WriteLine("---------------------------------");
            }

            public void CalculerPrixTVAC()
            {
                Console.WriteLine($"{Type} {Marque} vaut {PrixHTVA + (PrixHTVA / 100) * 21} EUR TVAC");
            }

        }

        static void MagasinDeVetements()
        {
            List<Vetement> stock = new List<Vetement>();

            // Déclaration de la variable de type de l'enum 
            //Vetement v;

            // Initialisation des différentes données contenues dans la variable
            //v.Marque = "Levi's";
            //v.Matiere = MatiereVetement.Tissu;
            //v.Taille = TailleVetement.XL;
            //v.Type = TypeVetement.TSHIRT;
            //v.PrixHTVA = 45.95;
            //v.Quantite = 5;
            //v.Couleur = CouleurVetement.Rouge;

            // Utilisation de la variable;
            // stock.Add(v);

            // Vetement v1;

            //v1.Marque = "Adidas";
            //v1.Matiere = MatiereVetement.Synthétique;
            //v1.PrixHTVA = 74.95;
            //v1.Quantite = 3;
            //v1.Taille = TailleVetement.M;
            //v1.Type = TypeVetement.PANTALON;
            //v1.Couleur = CouleurVetement.Blanc;

            //stock.Add(v1);

            /**
             * Magasin de vêtements
             * 1. Afficher tous les vêtements
             * 2. Acheter un vêtement
             * 3. Quitter
             * 
             * Si je tape 1
             * Vêtements --------------
             * ...
             * 
             * Si je tape 2
             * Affichage d'un achat avec le prix TVAC
             * Retirer la quantité du stock
             * 
             * --> Revenir au menu principal
             */
            bool fini = false;
            do
            {
                Console.SetCursorPosition(1, 1);
                Console.WriteLine("Magasin de Vêtements");
                Console.WriteLine("\t1. Afficher tous les vêtements");
                Console.WriteLine("\t2. Acheter un vêtement");
                Console.WriteLine("\t3. Insérer un nouveau vêtement");
                Console.WriteLine("\t4. Quitter");

                string reponse = Console.ReadLine();

                switch (reponse)
                {
                    case "1":
                        // Affichage
                        AfficherVetements(stock);

                        break;
                    case "2":
                        // Achat
                        // 1. Demander quel vêtement
                        // TYPE Prix
                        AcheterUnVetement(ref stock);

                        break;
                    case "3":
                        // Insérer un nouveau vêtement
                        InsererUnVetement(ref stock);
                        break;
                    case "4":
                        // Quitter
                        fini = true;
                        Console.WriteLine("Au revoir");
                        break;
                    default:
                        Console.WriteLine("Le choix n'est pas valide");
                        break;
                }
            } while (!fini);





        }

        public static void AfficherVetements(List<Vetement> stock)
        {
            Console.SetCursorPosition(1, 7);
            if (stock.Count > 0)
            {
                foreach (Vetement item in stock)
                {
                    item.Afficher();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aucun vêtement présent dans le stock");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public static void AcheterUnVetement(ref List<Vetement> stock)
        {
            Console.Clear();
            int choixVetement = -1;
            do
            {
                Console.WriteLine("Quel vêtement voulez-vous acheter ?");
                int compteur = 1;
                foreach (Vetement item in stock)
                {
                    Console.WriteLine($"{compteur}. [{item.Type}] : {item.PrixHTVA} EUR");
                    compteur++;
                }
                int.TryParse(Console.ReadLine(), out choixVetement);
            } while (choixVetement <= 0 || choixVetement > stock.Count);


            // Modifier le contenu de mon vêtement dans mon stock
            //stock[choixVetement - 1].Quantite--; // INTERDIT A CAUSE DE LA STRUCTURE

            // 2. Enlever du stock
            Vetement p = stock[choixVetement - 1];
            if (p.Quantite > 0)
            {
                stock.RemoveAt(choixVetement - 1);
                p.Quantite--;
                stock.Add(p);
                // Afficher le prix HTVA
                p.CalculerPrixTVAC();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"le vêtement [{stock[choixVetement - 1].Type}] n'est plus disponible");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadLine();
            Console.Clear();

        }

        public static void InsererUnVetement(ref List<Vetement> stock)
        {
            Console.Clear();

            Vetement nouveauVetement;

            // 1. Type du Vêtement
            nouveauVetement.Type = ChoisirTypeVetement();
            // 2. Marque du vêtement
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("Entrez la marque de votre vêtement");
            nouveauVetement.Marque = Console.ReadLine();
            Console.Clear();
            // 3. Matière du vêtement
            nouveauVetement.Matiere = ChoisirMatiereVetement();
            // 4. Couleur du vêtement
            nouveauVetement.Couleur = ChoisirCouleurVetement();
            // 5. Taille du vêtement
            nouveauVetement.Taille = ChoisirTailleVetement();
            // 6. Prix HTVA
            nouveauVetement.PrixHTVA = FixerPrixHTVA();
            // 7. Quantite
            nouveauVetement.Quantite = ChoisirQuantiteVetement();

            // Ajouter le nouveau vêtement au stock

            stock.Add(nouveauVetement);

            Console.Clear();

        }

        public static TypeVetement ChoisirTypeVetement()
        {
            // 1.a Recupérer le numéro du type de vêtement
            string[] valeursEnumType = Enum.GetNames(typeof(TypeVetement));
            int choix;
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("Quel type de vêtement souhaitez-vous ajouter ?");
            do
            {
                int compteur = 1;
                foreach (string item in valeursEnumType)
                {
                    Console.WriteLine($"{compteur}. [{item}]");
                    compteur++;

                }
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumType.Length);

            Console.Clear();
            // 1.b retourner le type de mon vêtement
            return (TypeVetement)Enum.Parse(typeof(TypeVetement), valeursEnumType[choix - 1]);

        }

        public static MatiereVetement ChoisirMatiereVetement()
        {
            // 3.a Récupérer le numéro de la matière
            int choix;
            string[] valeursEnumMatiere = Enum.GetNames(typeof(MatiereVetement));
            Console.SetCursorPosition(1, 1);
            do
            {
                Console.WriteLine("Choississez votre matière");
                int compteur = 1;
                foreach (string matiere in valeursEnumMatiere)
                {
                    Console.WriteLine($"{compteur}. [{matiere}]");
                    compteur++;

                }
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumMatiere.Length);

            Console.Clear();
            // 3.b retourner la matière de mon vêtement
            return (MatiereVetement)Enum.Parse(typeof(MatiereVetement), valeursEnumMatiere[choix - 1]);

        }

        public static CouleurVetement ChoisirCouleurVetement()
        {
            int choix;
            string[] valeursEnumCouleur = Enum.GetNames(typeof(CouleurVetement));
            Console.SetCursorPosition(1, 1);
            do
            {
                Console.WriteLine("Choississez la couleur");
                int compteur = 1;
                foreach (string couleur in valeursEnumCouleur)
                {
                    Console.WriteLine($"{compteur}. [{couleur}]");
                    compteur++;

                }
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumCouleur.Length);

            Console.Clear();
            // 4.b retourner la couleur de mon vêtement
            return (CouleurVetement)Enum.Parse(typeof(CouleurVetement), valeursEnumCouleur[choix - 1]);

        }

        public static TailleVetement ChoisirTailleVetement()
        {
            int choix;
            string[] valeursEnumTaille = Enum.GetNames(typeof(TailleVetement));
            Console.SetCursorPosition(1, 1);
            do
            {
                Console.WriteLine("Choississez la taille");
                int compteur = 1;
                foreach (string taille in valeursEnumTaille)
                {
                    Console.WriteLine($"{compteur}. [{taille}]");
                    compteur++;

                }
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > valeursEnumTaille.Length);

            Console.Clear();
            // 5.b retourner la couleur de mon vetement
            return (TailleVetement)Enum.Parse(typeof(TailleVetement), valeursEnumTaille[choix - 1]);

        }

        public static double FixerPrixHTVA()
        {
            double prixHTVA;
            Console.SetCursorPosition(1, 1);
            do
            {
                Console.WriteLine("Entrez un prix HTVA en EURO");
                double.TryParse(Console.ReadLine(), out prixHTVA);
            } while (prixHTVA <= 0);

            return prixHTVA;
        }

        public static int ChoisirQuantiteVetement()
        {
            int quantite;
            do
            {
                Console.WriteLine("Entrez la quantité du vêtement souhaitée");
                int.TryParse(Console.ReadLine(), out quantite);
            } while (quantite <= 0);

            return quantite ;
        }
    }
}
