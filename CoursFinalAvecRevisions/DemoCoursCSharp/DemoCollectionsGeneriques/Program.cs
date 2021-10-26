using System;
using System.Collections.Generic;

namespace DemoCollectionsGeneriques
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Génériques");

            int total = 0;

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);

            foreach (int item in list)
            {
                total += item;
            }

            Console.WriteLine(total);

            Dictionary<int, string> dico = new Dictionary<int, string>();
            dico.Add(1, "dkfk");

            foreach (KeyValuePair<int, string> item in dico)
            {
                Console.WriteLine(item.Value);
            }

            Dictionary<string, List<int>> bulletin = new Dictionary<string, List<int>>();



            // Collection simple de type List
            Console.WriteLine("Révisions Collections");

            List<string> listeChaines = new List<string>();
            listeChaines.Add("Bonjour");
            listeChaines.Add("Comment");
            listeChaines.Add("allez");
            listeChaines.Add("vous ?");

            Console.WriteLine(listeChaines.IndexOf("Comment"));

            for (int i = 0; i < listeChaines.Count; i++)
            {
                Console.WriteLine(listeChaines[i]);
                //if (i == 1)
                //{
                //    listeChaines[i] = "est-ce";
                //}
            }

            // A utiliser pour la consultation de la liste SANS devoir modifier son contenu car NON PERMIS à l'exécution
            foreach (string item in listeChaines)
            {
                Console.WriteLine(item);
                
            }

            List<int> test = new List<int>();
            test.Add(5);
            test.Add(8);
            //test.Remove(8);
            test.RemoveAt(1);
            Console.WriteLine(test[0]);

            foreach (int item in test)
            {
                Console.WriteLine(item * 2);
            }

            //listeChaines.ForEach(x => Console.WriteLine(x));


            Dictionary<string, int> cotations = new Dictionary<string, int>();
            cotations.Add("Ceuleers", 85);
            if (!cotations.ContainsKey("Ceuleers"))
            {
                cotations.Add("Ceuleers", 90);
            }
           

            //foreach (KeyValuePair<string, int> item in cotations)
            //{
            //    Console.WriteLine($"[{item.Key}] : {item.Value}");
            //}

            cotations["Ceuleers"] = 15;

            foreach (KeyValuePair<string, int> item in cotations)
            {
                Console.WriteLine($"[{item.Key}] : {item.Value}");
            }

            

        }
    }
}
