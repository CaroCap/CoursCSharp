using System;

namespace DemoBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Structures itératives");
            //BoucleTantQue();
            //BoucleFaireTantQue();
            //InputCorrectIteration();
            //BouclePourFaire();
            BouclePourChaqueFaire();

        }

        /**
         * while (condition) 
         * {
         * 
         * }
         * */
        static void BoucleTantQue()
        {
            int compteur = 0;

            while (compteur < 10)
            {
                Console.WriteLine(compteur);
                compteur++;
            }


        }

        /**
         * do 
         * {
         * 
         * } while (condition)
         */
        static void BoucleFaireTantQue()
        {
            int compteur = 0;

            do
            {
                Console.WriteLine(compteur);
                compteur++;
            } while (compteur < 10);

        }

        static void InputCorrectIteration()
        {
            Console.WriteLine("Entrez un nombre entier");

            while(int.TryParse(Console.ReadLine(), out int bonEntier) == false)
            {
                Console.WriteLine("Entrez un nombre entier");
            }

            Console.WriteLine($"OK");

            // VERSION OPTIMISEE;
            int doBonEntier;
            do
            {
                Console.WriteLine("Entrez un nombre entier");
            } while (!int.TryParse(Console.ReadLine(), out doBonEntier));
            Console.WriteLine(doBonEntier);
            Console.WriteLine("REOK");
            
        }

        /**
         * for(int i = 0; i < length; i++)
         * {
         * 
         * }
         */
        static void BouclePourFaire()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
        /**
         * foreach(var item in collection)
         * 
         * Itération sur des collections de données
         * UNIQUEMENT POUR LA CONSULTATION ("lecture seule")
         */
        static void BouclePourChaqueFaire()
        {
            string s = "bonjour tout le monde";
            foreach(char item in s.ToCharArray())
            {
                Console.WriteLine(item);
            }
        }
    }
}
