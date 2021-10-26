using System;
using GetBankRappel.Models;

namespace GetBankRappel
{
    class Program
    {
        static void Main(string[] args)
        {
            //premiere methode pour instancier un objet qui ne possede pas de constructeur
            // constructeur vide = ()
            Personne client1 = new Personne();
            client1.Nom = "Hurlet";
            client1.Prenom = "Laure";
            client1.DateNaiss = new DateTime(1985, 02, 23);

            //deuxieme façon d'instancier un objet avec un constructeur vide
            Personne client2 = new Personne() { Nom = "Cap", Prenom = "Caroline", DateNaiss = new DateTime(1990, 01, 16) };

            Console.WriteLine($"{client1.Nom} - {client1.Prenom}");
            Console.WriteLine($"{client2.Nom} - {client2.Prenom}");
        }
    }
}
