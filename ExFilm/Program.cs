using System;
using ExFilm.models;

namespace ExFilm
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne Pers1 = new Personne();
            Pers1.Nom = "Cap";
            Pers1.Prenom = "Caroline";
            Console.WriteLine(Pers1.Manger());

            Realisateur Real1 = new Realisateur();
            Real1.Nom = "Tarantino";
            Real1.Prenom = "Quentin";
            Real1.AfficheFilm();
            Console.WriteLine(Real1.Manger());

            Acteur Act1 = new Acteur();
            Act1.Nom = "Thurman";
            Act1.Prenom = "Uma";
            Act1.AfficheFilm();
            Console.WriteLine(Act1.Manger());

            Acteur Act2 = new Acteur()
            {
                Nom = "Liu",
                Prenom = "Lucy"
            };

            Film Film1 = new Film();
            Film1.Titre = "Kill Bill";
            Film1.AnneeSortie = 2003;
            Film1.acteurPrincipal = Act1;
            Film1.leRealisateur = Real1;

            Console.WriteLine($"Le film préféré de {Pers1.Prenom} est {Film1.Titre} réalisé par {Real1.Prenom +" " + Real1.Nom} en {Film1.AnneeSortie} avec {Act1.Prenom + " " + Act1.Nom}.");

        }
    }
}
