using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructures
{
    /**
     * Ecrire deux structures Celsius et Fahrenheit
     * toutes deux ayant une variable de type double 
     * appelée « Temperature ».
     * Ajouter une méthode de conversion de l'un vers l'autre
     */
        class Temperature
    {
        public struct Celsius
        {
            public double Temperature;

            public void Conversion()
            {
                Console.WriteLine($"{Temperature} en Farenheit correspond à {Temperature * 9/5 + 32}°F");
            }
        }

        public struct Farenheit
        {
            public double Temperature;

            public void Conversion()
            {
                Console.WriteLine($"{Temperature} en Celsius correspond à {(Temperature - 32) / 9 * 5,0:F2}°C");
            }
        }

        static void Main(string[] args)
        {
            Celsius t1;
            Farenheit t2;

            char choix = ' ';
            double temperature;
            do
            {
                Console.WriteLine("Entrez la température");

            } while (!double.TryParse(Console.ReadLine(), out temperature));

            do
            {
                Console.WriteLine("Quelle unité choisissez-vous (C/F) ?");
                choix = Console.ReadLine()[0];
            } while (choix != 'C' && choix != 'F');

            switch (choix)
            {
                case 'C':
                    t1.Temperature = temperature;
                    t1.Conversion();
                    break;
                case 'F':
                    t2.Temperature = temperature;
                    t2.Conversion();
                    break;
            }


        }
    }
}
