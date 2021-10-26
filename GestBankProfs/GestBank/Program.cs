using GestBank.Models;
using System;

namespace GestBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne client1 = new Personne();
            //client1.Nom = "Adnet";
            //client1.Prenom = "Geoffroy";
            //client1.DateNaiss = new DateTime(1980, 06, 24);
            //Personne client1 = new Personne()
            //{
            //    Nom = "Adnet",
            //    Prenom = "Geoffroy",
            //    DateNaiss = new DateTime(1980, 06, 24)
            //};
            Personne client1 = new Personne("Adnet", "Geoffroy", new DateTime(1980, 06, 24));
            //Console.WriteLine($"Nom : {client1.Nom}");
            //Console.WriteLine($"Prenom : {client1.Prenom}");
            //Console.WriteLine($"Date de naissance : {client1.DateNaiss}");

            //Courant compteCourant = new Courant();
            //compteCourant.Numero = "000000001";
            //compteCourant.Titulaire = client1;
            //compteCourant.LigneDeCredit = 500;
            Courant compteCourant = new Courant("000000001", client1, 0, 500);

            Console.WriteLine($"Compte courant du client {compteCourant.Titulaire.Prenom}");
            Console.WriteLine("Avant interêt");
            compteCourant.Depot(500);
            Console.WriteLine(compteCourant.Solde);
            compteCourant.Retrait(750);
            Console.WriteLine(compteCourant.Solde);
            Console.WriteLine("Après interêt");
            compteCourant.AppliquerInteret();
            Console.WriteLine(compteCourant.Solde);
            //Epargne compteEpargne = new Epargne();
            //compteEpargne.Numero = "000000002";
            //compteEpargne.Titulaire = client1;
            Epargne compteEpargne = new Epargne("000000002", client1);

            Console.WriteLine($"Compte épargne du client {compteEpargne.Titulaire.Prenom}");
            Console.WriteLine("Avant interêt");
            compteEpargne.Depot(500);
            Console.WriteLine(compteEpargne.Solde);
            compteEpargne.Retrait(150);
            Console.WriteLine(compteEpargne.Solde);
            Console.WriteLine(compteEpargne.DernierRetrait);
            Console.WriteLine("Après interêt");
            compteEpargne.AppliquerInteret();
            Console.WriteLine(compteEpargne.Solde);

        }
    }
}
