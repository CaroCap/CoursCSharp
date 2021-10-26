using System;

namespace DemoVariables
{
    class Program
    {
        // Variables membres (global)
        // Elle va être initialisée par la valeur par défaut du Type
        // de la variable
        // -> 0 pour les int
        // -> "" pour les string
        // -> ' ' pour les char
        // -> null pour les objets
        static int X;
        static string Message = "Message Global";

        // Définition d'une Constantes global;
        const int CONST_X = 999;

        static void Main(string[] args)
        {
            Console.WriteLine("Démonstration Variables");

            // Déclaration de la variable (type + nom)
            int a;
            // Initialisation de la variable avec sa première valeur
            a = 5;
            // Utilisation ...
            Console.WriteLine($"{a}");

            int b = 9;

            // Multi-déclaration
            int c = 4, d = 6;

            Console.WriteLine($"{X}");
            
            X = 20;
            //Afficher();

            // Variable locale (accessible que dans la fonction qui la définit)
            // Obligation d'initialiser la variable locale
            // avant toute utilisation
            // Sinon ERREUR
            int Y = 10;
            Console.WriteLine($"{Y}");

            // Appel la variable global
            //Console.WriteLine(Message);
            Element demoDissimulation = new Element();
            demoDissimulation.Afficher();

            // Etant une constante, je ne peux jamais réaffecter
            // une valeur dans la variable
            //CONST_X = 85;


            // Type Nullable
            double i = 5.616516511;
            // Utilisation du type spécifique Nullable<T> qui "encapsule" le type int
            // avec la gestion de la valeur NULL
            Nullable<int> iNull = null;

            // Nouvelle écriture avec le ? (Type?)
            int? jNull = null;
            jNull = 5;

            bool condition = true | false ;
            bool? conditionNull = true | false | null;



        }

        static void Afficher()
        {
            Console.WriteLine(X);

            // Interdit car la variable Y est définie localement dans la méthode Main()
            // et n'existe que dans cette méthode

            //Console.WriteLine(Y);
            
            //Dissimulation de la variable global Message
            string Message = "Message local";
            Console.WriteLine(Message);

            // Appel la variable global dissimulée
            //Console.WriteLine(this.Message);

            // Initialisation obligatoire à cause de l'appel ligne 76
            string MessageBoucle = "";
            for (int i = 0; i < 10; i++)
            {
                MessageBoucle = "Message ultra localisé" + i;
                // Message interne n'est accessible que dans la boucle
                // for
                string MessageInterne = "Message de la boucle";
                Console.WriteLine(MessageInterne);
            }

            Console.WriteLine(MessageBoucle);
        }
    }
}
