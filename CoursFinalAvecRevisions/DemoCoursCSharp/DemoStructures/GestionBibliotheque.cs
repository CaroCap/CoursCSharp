using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructures
{
    class GestionBibliotheque
    {
        public struct Livre
        {
            public string titre;
            public string auteur;
            public Dictionary<string, string> chapitres;

            public void Afficher()
            {
                Console.Write($"{titre}\n\t{auteur}\n");
                foreach (KeyValuePair<string,string> chapitre in chapitres)
                {
                    Console.WriteLine($"{chapitre.Key}\n{chapitre.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            List<Livre> bibliotheque = new List<Livre>();
            
            Livre p;
            
            p.titre = "Les quatre accords Tolteques";
            p.auteur = "Cuelho";
            p.chapitres = new Dictionary<string, string>
            {
                { "Chapitre 1", "Lorem ipsyumo ..." },
                { "Chapitre 2", "Lorem ipsyumo ..." },
                { "Chapitre 3", "Lorem ipsyumo ..." }
            };

            Livre p1;

            p1.titre = "La seigneur des Anneaux";
            p1.auteur = "Tolkien";
            p1.chapitres = new Dictionary<string, string>
            {
                { "Chapitre 1", "Lorem ipsyumo ..." },
                { "Chapitre 2", "Lorem ipsyumo ..." },
                { "Chapitre 3", "Lorem ipsyumo ..." },
                { "Chapitre 4", "Lorem ipsyumo ..." },
                { "Chapitre 5", "Lorem ipsyumo ..." },
                { "Chapitre 6", "Lorem ipsyumo ..." }

            };


            bibliotheque.Add(p);
            bibliotheque.Add(p1);

            foreach (Livre livre in bibliotheque)
            {
                //livre.Afficher();
                Console.WriteLine(livre.titre);
                Console.WriteLine(livre.chapitres["Chapitre 3"]);
            }

        }
    }
}
