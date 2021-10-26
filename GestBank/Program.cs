using System;
using GestBank.Models;

namespace GestBank
{
    class Program
    {
        static void Main(string[] args)
        {

            // Création de Personnes (2 manières de faire)
            Personne P1 = new Personne();
            P1.Prenom = "Caroline";
            P1.Nom = "Cap";
            P1.DateNaiss = new DateTime(1990, 01, 16);

            Personne P2 = new Personne()
            {
                Prenom = "Alexis",
                Nom = "Decarpentrie",
                DateNaiss = new DateTime(1974, 12, 03)
            };

            Console.WriteLine(P1.Prenom + " " + P1.Nom + " " + P1.DateNaiss);

            // Création Compte courant
            Courant compteCourant = new Courant();
            compteCourant.Numero = "BE000001";
            compteCourant.Titulaire = P1;
            compteCourant.LigneDeCredit = 500;

            compteCourant.Depot(500);
            Console.WriteLine(compteCourant.Solde);
            compteCourant.Retrait(750);
            Console.WriteLine(compteCourant.Solde);

            Epargne compteEpargne = new Epargne();
            compteEpargne.Numero = "BE0000002";
            compteEpargne.Titulaire = P1;

            compteEpargne.Depot(500);
            Console.WriteLine("Solde restant : " + compteEpargne.Solde);
            compteEpargne.Retrait(150);
            Console.WriteLine("Solde restant : " + compteEpargne.Solde);
            Console.WriteLine("Date du Dernier Retrait : " + compteEpargne.DernierRetrait);

        }
    }
}
