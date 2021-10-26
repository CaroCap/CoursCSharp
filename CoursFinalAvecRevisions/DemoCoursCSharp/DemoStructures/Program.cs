using System;
using System.Collections.Generic;

namespace DemoStructures
{
    class Program
    {
        public struct JourSemaine
        {
            public string lundi;
            public string mardi;

            public List<string> jours;

            public const string mercredi = "mercredi";
        }

       
        public enum Droit
        {
            Execute,
            Read,
            Write
        }

        public enum Semaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        public enum Genre
        {
            M,
            F
        }
        public struct Personne
        {
            public const string SAIS_PAS = "irrirjij";
            public string nom;
            public string prenom;
            public DateTime dateNaissance;
            public bool estMarrie;
            public Genre genre;

            
            public void Afficher()
            {
                Console.WriteLine(nom + " " + prenom + " " + dateNaissance + " " + estMarrie);
            }
        }
        static void Main(string[] args)
        {
            JourSemaine jour;
            jour.lundi = "lundi";

            Semaine dimanche = Semaine.Dimanche;
            Console.WriteLine((int)Semaine.Jeudi);
            

            jour.jours = new List<string>() { "lundi", "mardi" };

            //Console.WriteLine(jour.jours[0]);
            //Console.WriteLine(JourSemaine.mercredi);
            Console.WriteLine(Semaine.Dimanche);
            Console.WriteLine((int)Semaine.Dimanche);

            Droit droitsDeLUtilisateur = Droit.Execute | Droit.Read;

            if (droitsDeLUtilisateur.HasFlag(Droit.Execute))
            {
                Console.WriteLine("Peux exécuter");
            }
            if (droitsDeLUtilisateur.HasFlag(Droit.Read))
            {
                Console.WriteLine("Peux lire");
            }
            if (droitsDeLUtilisateur.HasFlag(Droit.Write))
            {
                Console.WriteLine("Peux écrire");
            }

            foreach (string value in Enum.GetNames(typeof(Semaine)))
            {
                Console.WriteLine(value);
            }

            string s = "Mercredi";
            Semaine mer = (Semaine)Enum.Parse(typeof(Semaine), s);
            Console.WriteLine((int)mer);

            Console.WriteLine("Entrez le jour de le semaine");
            string jourSemaine = Console.ReadLine();


            //Console.WriteLine("Demo Structure");
            //Personne p;
           
            //p.nom = "Ceuleers";
            //p.prenom = "Greg";
            //p.dateNaissance = new DateTime(1980, 6, 26);
            //p.estMarrie = false;
            //p.genre = Genre.M;

            //Personne p2 = p;

            //p2.nom = "Ly";
            //p2.prenom = "Khun";
            
            
            //List<Personne> liste = new List<Personne>();
            //liste.Add(p);
            //liste.Add(p2);
            
            //List<Personne> liste2 = liste;
            //liste2.RemoveAt(0);

            //foreach (Personne item in liste)
            //{
            //    item.Afficher();
            //    //Console.WriteLine(item);
            //}
            

        }
    }
}
