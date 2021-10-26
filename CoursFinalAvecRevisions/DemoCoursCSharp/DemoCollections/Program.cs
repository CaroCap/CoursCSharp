using System;
using System.Collections;

namespace DemoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démo Collections");
            Console.WriteLine("1. Demo Arraylist");
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Bonjour");
            list.Add('A');
            list.Add(1.5);
            list.Add('A');
            list.Remove('A');
            int val1 = 0;
            double val2 = 0;

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (object item in list)
            {
                Console.WriteLine(item.ToString());
                if (list[list.IndexOf(item)].Equals(1))
                {
                    val1 = (int)item;
                }
                if (item.Equals(1.5))
                {
                    val2 = (double)item;
                }

            }

            Console.WriteLine(val1 + val2);


            Hashtable dictionnaire = new Hashtable();

            dictionnaire.Add(1, "Bonjour");
            dictionnaire.Add("2", 15.6);
            dictionnaire.Add("CeuleersGregory", new int[] { 1, 2, 3 });

            Console.WriteLine((double)dictionnaire["2"]
                + ((int[])dictionnaire["CeuleersGregory"])[1]);

            foreach (DictionaryEntry item in dictionnaire)
            {
                Console.WriteLine($"La clé [{item.Key}] a comme valeur : {item.Value}");
            }

            foreach (object key in dictionnaire.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (object value in dictionnaire.Values)
            {
                Console.WriteLine(value);
            }


        }
    }
}
