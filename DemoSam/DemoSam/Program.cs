using System;
using System.Collections.Generic; // POUR POUVOIR UTILISER LES LISTES

namespace DemoSam
{
    class Program
    {
        static void Main(string[] args)
        {
            //var DOIT SE TYPER DÈS QU'ON LE DECLARE ET N'EST PLUS MODIFIABLE
            var message = "Hello wordl";
            //message = 5; //créée une erreur car changement de type String - Int
            //dynamic PERMET DE CHANGER LE TYPE DE MA VARIABLE DYNAMIQUEMENT MAIS EST TRES DECONSEILLE !!!
            dynamic message2 = "Hello you";
            message2 = 5;
            //Suffixe permet d'ajouter une lettre pour préciser si D(double) F(float) M(décimal)
            var number = 5D;
            number = 2; // restera un double comme préciser dans la déclaration avec suffixe
            Console.WriteLine(number.GetType()); //pour récupérer le type CTS de la variable -> System.String - System.Single (pour float)
                                                 //F5 pour executer rapidement



            //CLASS => plan de construction MAIS pas création de la voiture physique
            // EX Voiture => description => int nbreRoues, Colors Couleur, String PlaqueId
            //              et Methode => Rouler(), Klaxoner()
            //INSTANCIATION => Production de la voiture 
            // EX new Voiture() -> nbreRoues : 4, Couleur : Rouge, PlaqueId : 1.ABC.123
            // AFFECTATION => Donner nom à ma voiture
            // Voiture Ferrari = new Voiture();
            // Voiture Fraise = Ferrari; => va lier les 2 variables en copiant le chemin de la variable
            // Ferrari.brRoues = 3; => donc si on modifie le nombre de roues de Ferrari, ça modifiera automatiquement Fraise.

            class UserProfile
            {
                // prop + doubleTabulation pour automatiquement créer un propriété public avec get et set
                public int MyProperty { get; set; }
            }


            //TYPE ANONYME ('a)=> new { NomDeFamille = UserProfile.Nom }
            var infoUser = new { NomDeFamille = UserProfile.Nom, Prenom = UserProfile.Prenom };
            //Possibilité de mettre des infos brutes dans le type anonyme
            var infoUser2 = new { NomDeFamille = "Willis", Prenom = "Bruce" };
            // Si même noms de propriété, on peut les combiner
            infoUser = infoUser2;


            // LISTES => ajouter en haut de page System.Collection.Generic
            List<string> listeString = new List<string> { "Caro", "Sam" };
            // pas possible de faire avec <var> sans LinQ
            List<var> listeVar = new List<var> { "Caro", "Sam" };


        }
        // LAMBDA => on peut créer une DELEGATE qui se trouvera au même niveau que class ou Struct pour pouvoir instancier une opération facilement sans devoir créer une structure compliquée avec une méthode ...
        delegate int OperationMath(int nb1, int nb2);
    }
}
