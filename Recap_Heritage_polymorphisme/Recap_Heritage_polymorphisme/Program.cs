using System;

namespace Recap_Heritage_polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne pers = new Personne();

            Maman maman = new Maman();
            maman.SetGame("7 wonders duel");
            maman.Nom = "Michel";
            maman.Prenom = "Aurélie";
            maman.parler("il se plaint que je parle trop");
            maman.LireUnLivre();
            maman.AimeLesChats = true;
            Console.WriteLine(maman.Boire("une RocheHaut Triple"));

            Papa papa = new Papa();
            papa.Nom = "Adnet";
            papa.Prenom = "Geoffroy";
            papa.AimeLesJeuxdeSociétés = true;
            papa.parler("j'ai jamais grand chose à dire");
            papa.JoueAuVolley();

            Enfant fille = new Enfant();
            fille.Nom = "Adnet";
            fille.Prenom = "Constance";
            fille.parler("je dois aller chez la logopède pour un chuintement");
            fille.LireUnLivre();
            fille.SetGame("poupées");
            fille.GetGame();
            fille.Jouer("Les jouets de mon petit frère");
            Console.WriteLine(fille.Boire("de l'oasis"));

        }
    }
}
