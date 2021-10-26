using System;

namespace DemoStructuresConditionnelles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démo Structures Conditionnelles");

            //DemoIfElse();
            DemoSwitchCase();
        }

        static void DemoSwitchCase()
        {
            Console.WriteLine("Affichage d'un menu");
            Console.WriteLine("\t1. Lancer recherche.");
            Console.WriteLine("\t2. Executer une copie.");
            Console.WriteLine("\t3. Quitter.");

            int.TryParse(Console.ReadLine(), out int choix);

            switch (choix)
            {
                case 1:
                    Console.WriteLine("JE lance une recherche");
                    Console.WriteLine("Cela fonctionne");
                    break;
                case 2:
                    Console.WriteLine("J'exécute une copie");
                    Console.WriteLine("Cela fonctionne tjs");
                    break;
                case 3:
                    Console.WriteLine("Au revoir");
                    Console.WriteLine("...");
                    break;
            }

            switch (Console.ReadLine())
            {
                case "abc":
                    Console.WriteLine("Tu connais ton alphabet");
                    break;
                default:  // facultatif
                    Console.WriteLine("Je rentre ici tjs que la valeur est différente de abc");
                    break;
            }

        }

        static void DemoIfElse()
        {
            int Age = 40;
            string Name = "Greg";

            // Opérateurs de comparaison
            // ==, !=, < ,<=, >, >=

            // Opérateurs de combinaison (combiner +sieurs conditions entres-elles)
            // && AND , || OR , ! NOT

            if (Age < 50  && Name != "Greg")
            {
                Console.WriteLine("Je suis pas encore trop vieux"); // TRUE
            } else if (Age < 50)
            {
                Console.WriteLine("Tu ne peux pas t'appeler Greg");
            } else
            {
                Console.WriteLine("Cela commence à se faire sentir..."); // FALSE
            }

            // Uniquement si vous avez UNE seule instruction à exécuter 
            if (Age < 50 && Name != "Greg") Console.WriteLine("Je suis pas encore trop vieux"); // TRUE
            else if (Age < 50) Console.WriteLine("Tu ne peux pas t'appeler Greg");
            else Console.WriteLine("Cela commence à se faire sentir..."); // FALSE



            
        }
    }
}
