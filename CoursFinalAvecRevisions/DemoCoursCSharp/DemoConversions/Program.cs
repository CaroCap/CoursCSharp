using System;

namespace DemoConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démo sur les conversions");
            //ConvertirDeTypeValeurEnString();
            //ConvertirDeStringVersTypeValeur();
            //ConversionImplicite();
            ConversionExplicite();


        }

        static void ConvertirDeStringVersTypeValeur()
        {
            string str = "574";
            
            // 1 Méthode Parse

            // Attention, si le contenu de la variable STRING
            // ne peut pas être convertie en TYPE VALEUR
            // ERREUR -> Arrêt de votre programme !!!
            // A gérer plus tard ...
            
            int i = int.Parse(str);

            Console.WriteLine(str + 2);
            Console.WriteLine(i + 2);

            // 2 Méthode TryParse

            string str1 = "3.14rfrg";
            //double res = default(double); // == 0
            double res = 0;
            bool b = double.TryParse(str1, out res);
            Console.WriteLine($"Conversion {b}");
            Console.WriteLine(str1 + str1);
            Console.WriteLine(res + res);

            // 3 Classe Convert
            // Attention : si la conversion échoue
            // ERREUR
            // A gérer plus tard ...

            float f = Convert.ToSingle("15.9");
            Console.WriteLine(f);

        }

        static void ConvertirDeTypeValeurEnString()
        {
            // Type Valeur
            int a = 5; // 0000000000000000000000000101
            // Type Référence
            string s = "Bonjourfoijroifj";
            s = "efoijoiefvjioefvjioefjviojv";
            Console.WriteLine(s);

            // Types Valeurs - 14 (pg 39)
            int i = 5;
            long l = 15L;
            double pi = 3.14;
            float fl = 3.14F;
            bool b = true;
            uint iNonSigne = 6;
            char c = 'C';

            string iStr = i.ToString();
            string lStr = l.ToString();
            string bStr = b.ToString();

            Console.WriteLine(iStr);
            // idem pour les autres variables
        }

       static void ConversionImplicite() // pg 49
        {
            short petitEntier = 15;
            int entier = petitEntier;
            long l = petitEntier;
            double d = petitEntier;
            float f = petitEntier;
            decimal dec = petitEntier;
           

            double dou = 54.15;
            dou = f;

            Console.WriteLine($"Valeur {entier}\tType de la donnée {entier.GetType()}");

         
            
        }

        static void ConversionExplicite()
        {
            int entier1 = 32769;
            short petitEntierAProbleme = (short)entier1;
            Console.WriteLine($"Valeur {petitEntierAProbleme}");

            int NbrFichiersTotal = 208;
            int NbrFichiersCopies = 52;

            int Pourcent = (int)(100F / NbrFichiersTotal * NbrFichiersCopies);

            Console.WriteLine(Pourcent);
        }
    }
}
