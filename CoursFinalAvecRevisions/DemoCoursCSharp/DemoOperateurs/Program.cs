using System;
using System.Collections.Generic;

namespace DemoOperateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Opérateurs");

            /**
             * Opérateurs arithmétique
             */
            // +, -, * , / , %

            Console.WriteLine(15D / 6);
            int dividende = 15, diviseur = 6;
            Console.WriteLine((double)dividende / diviseur);

            /**
             * Opérateurs de comparaisons
             */
            // <, <= , ==, !=, >, >=
            bool condition = 5 > 9;

            /**
             * Opérateurs de conditions
             */
            // && AND, || OU, ! NOT, ^ OU exclusif (pour avoir vrai,
            // il faut que le résultat des 2 conditions soient tjs
            // de valeurs différentes

            /**
             * Opérateur ternaire
             * -> raccourci pour faire une affectation conditionnelle
             * ?  si la condition est vrai
             * :  si la condition est fausse
             */
              //                   / VRAI / FAUX
            int ternaire = 65 > 10 ?  5   : -5;
            string tern = 65 > 10 ? "Vrai" : "Faux";
            // EST EQUIVALENT
            if (65 > 10)
            {
                ternaire = 5;
            } else
            {
                ternaire = -5;
            }

            /**
             * Opérateur coalesce ??
             * Opération à évaluer en 1er ?? Opération évaluée SI la première est NULLE
             */
            string testNull = null;
            string coalesce = TestNull() ?? null ?? "Bonjour";
            Console.WriteLine(coalesce);

            /**
             * Opérateur PRE / POST incr et decrémentation
             */

            int i = 5;
           // i++;
            Console.WriteLine(i); // 6
            Console.WriteLine(i--); // 6
            Console.WriteLine(++i); // 6
            Console.WriteLine(--i); // 5
            int val = 10;
            
            val += 5; // <> val = val + 5
            val -= 2; // ...
            val *= 4;
            val /= 2;
            val %= 2;

            object o = 5L;
            Type t = typeof(object);
            Console.WriteLine(t.Name);
            switch (t.Name)
            {
                case "Int32":
                    break;
            }

            string s = "efuvj oirejv  ooie v";
            string morceauDeS = s.Substring(6, 6);
            Console.WriteLine(morceauDeS);
           
                //BBAN
                // 125-1254789-85

                // 123412341234
                // IBAN
                // BE12 1254 1254 6587

            
        }

        static string TestNull()
        {
            return null;
        }
    }
}
