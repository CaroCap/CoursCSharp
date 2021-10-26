using System;

namespace DemoTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Tableaux");
            
            // Tableaux uni-dimensionels

            int[] tableau = new int[5];

            string[] jours = new string[]
            {
                "lundi",
                "mardi",
                "..."
            };

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = i + 1;
                Console.WriteLine(tableau[i]);

            }

            // Tableaux multi-dimensionels

            // 1. Matriciels
            int[,] matrice = new int[2, 5];

            int[,] matrice2 = new int[,]
            {
                {1,2,3 },
                {4,5,6 }
            };

            for (int i = 0; i < matrice2.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrice2.GetLongLength(1); j++)
                {
                    Console.Write(matrice2[i,j] + "\t");
                }
                Console.WriteLine();
            }

            // 2. Orthogonaux

            int[][] orthogonal = { new int[2], new int[] { 1, 2, 3, 4 } };

            for (int i = 0; i < orthogonal.GetLength(0); i++)
            {
                Console.WriteLine(orthogonal[0][i]);
            }
            for (int i = 0; i < orthogonal[1].Length; i++)
            {
                Console.WriteLine(orthogonal[1][i]);
            }

            Console.WriteLine("Révisions");
            int[] tabInit = new int[5];

            for (int i = 0; i < tabInit.Length; i++)
            {
                tabInit[i] = i;
            }

            // Ajouter un 6ième élément à mon tableau
            // Obligation de créer un nouveau tableau de taille +1
            // Copier les anciennes valeurs
            // Insérer le nouvel élément
            int[] tabInitCopy = new int[6];
            for (int i = 0; i < tabInitCopy.Length; i++)
            {
                if (i <= 4)
                {
                    tabInitCopy[i] = tabInit[i];
                } else
                {
                    tabInitCopy[i] = 10;
                }
               
                Console.WriteLine(tabInitCopy[i]);

                

            }

            Console.WriteLine("Tableau à 2 dimensions (grille)");
            int[,] grille = new int[3, 3];
            int value = 1;

            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    grille[i, j] = value;
                    value++;
                    Console.Write(grille[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int[][] ortho = new int[2][];
            ortho[0] = new int[] { 1, 2, 3 };
            ortho[1] = new int[] { 4, 5, 6, 7, 8, 9 };

            ConsoleKeyInfo touche = Console.ReadKey();
            Console.WriteLine(touche.Key == ConsoleKey.UpArrow);

        }
    }
}
