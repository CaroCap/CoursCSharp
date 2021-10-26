using System;

namespace DemoVariables
{
    class Program
    {

        // Possible de faire Déclaration Variable MEMBRE (GLOBAL)
        static int 
        //Préinitialisé automatiquement par la valeur par défaut du type.
        // -> int = 0 ; string = "" ; char = ' ' (espace) ; pour les objets = NULL 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Démonstration Variables");

            //Déclaration de la variable LOCALE (type + nom)
            //Obligation de l'initialiser avant de pouvoir l'utiliser sinon ERREUR
            int nomVariable;

            //Initialisation de la variable avec sa première valeur
            nomVariable = 5;

            //Les 2 en 1
            string nomVar2 = "autre exemple";

            //Utilisation de la variable
            Console.WriteLine($"{nomVariable} {nomVar2}");

            // Multi-déclaration
            int c = 4, d = 6;

        }
    }
}
