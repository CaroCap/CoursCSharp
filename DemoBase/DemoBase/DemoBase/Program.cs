using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoBase
{

    class Program
    {
        //le contenu d'une énumération s'écrit en majuscule
        public enum TypeDeNourriture { 
            ASIATIQUE=2, 
            ITALIEN=4, 
            LIBANAIS=8, 
            THAI=16, 
            INDIEN=32, 
            ETHIOPIEN=64 
        }

        static void Main(string[] args)
        {
            //pour créer une région #region nom de la region
            #region Methode
            ///Exemple test;

            //test.UneProcedure();

            //string resultat = test.UneFonction();
            //Console.WriteLine(resultat);
            //Console.WriteLine(test.UneFonction());
            //string majeur = test.EstMajeur();
            //Console.WriteLine(test.EstMajeur());

            //if (test.TheDoomGeneration(12, false))
            //{
            //    Console.WriteLine("je peux regader The Doom Generation");
            //}
            //else
            //{
            //    Console.WriteLine("je vais regarder pow patrol");
            //}

            //test.WarHammer40k("Grey Knights");
            //test.WarHammerAoS("Orc");
            //test.WarHammerAoS();

            //Console.WriteLine(test.Moyenne(10,12,16,18,3));
            //Console.WriteLine(test.Moyenne(10, 12, 16, 18, 3, 5, 18,6, 29,14));

            //test.AfficheJeu(65);

            //je clôture la région par un #endregion
            #endregion

            #region Enum
            //TypeDeNourriture type = TypeDeNourriture.LIBANAIS;
            //Console.WriteLine($"{type} - {(int)type}");

            ////parcourir une énumération pour ressortir les valeurs numérique associée
            //foreach (int val in Enum.GetValues(typeof(TypeDeNourriture)))
            //{
            //    Console.WriteLine(val);
            //}

            ////parcourir une énumération pour ressortir les valeurs littéraire associée
            //foreach (string val in Enum.GetNames(typeof(TypeDeNourriture)))
            //{
            //    Console.WriteLine(val);
            //}

            //foreach(TypeDeNourriture t in Enum.GetValues(typeof(TypeDeNourriture)))
            //{
            //    Console.WriteLine(t);
            //}

            //int value = (int)Enum.Parse(typeof(TypeDeNourriture), "INDIEN");
            //Console.WriteLine(value);
            //type = (TypeDeNourriture)Enum.Parse(typeof(TypeDeNourriture), "ETHIOPIEN");
            //Console.WriteLine($"{type} - {(int)type}");

            //Voiture voiture;
            //voiture.marque = "VW";
            //voiture.carburant = Carburant.DIESEL;

            //Console.WriteLine($"{voiture.marque} - {voiture.carburant}");






            ////BONUS
            ////utilisation d'un switch sur valeur string
            //string choix = "ASIATIQUE";
            ////je peux commencerp ar vérifier si l'élément choisi fait bien partie de l'énumération
            ////pour ce faire j'utilise la méthode isdefined de la classe Enum qui prendra 2 paramètres, l'enum et la valeur a chercher dedans
            ////l'énum doit être en typeof pour que la recherche se fasse sur la partie string ou int en fonction de la valeur à chercher.
            //if(Enum.IsDefined(typeof(TypeDeNourriture), choix))
            //{
            //    switch (choix)
            //    {
            //        case nameof(TypeDeNourriture.ASIATIQUE):
            //            Console.WriteLine("good");
            //            break;

            //        default:
            //            Console.WriteLine("c'est bon aussi");
            //            break;
            //    }
            //} 
            //else
            //{
            //    Console.WriteLine("Ce type de nouriturre ne fais pas partie de notre menu");
            //}

            #endregion

            #region List arraylist
            //ArrayList list = new ArrayList();
            //list.Add(42);
            //list.Add("Stefania");
            //list.Add(true);
            //list.Add(19.9);


            List<int> listInt = new List<int>();

            #endregion

            #region hashtable dictionary
            //Hashtable dictionnaireFourreTout = new Hashtable();
            //dictionnaireFourreTout.Add(1, "Caroline");
            //dictionnaireFourreTout.Add("wad21", "Interface3");
            //dictionnaireFourreTout.Add(true, 42);

            //foreach(DictionaryEntry entree in dictionnaireFourreTout)
            //{
            //    Console.WriteLine($"{entree.Key} - {entree.Value}");
            //}
            //Dictionnary<T, U> -> T c'estl e typeque je défni pour la clé, U le type pour la valeur
            //Dictionary<int, string> DictionnaireGenerique = new Dictionary<int, string>();
            //DictionnaireGenerique.Add(1, "Valérie");
            //DictionnaireGenerique.Add(42, "La réponse universelle");
            //DictionnaireGenerique.Add(33, "Interface3");

            ////modification d'une valeur associée à une clé passée en paramètre
            //DictionnaireGenerique[33] = "Centre de Formation";
            ////pour ajouter je peux aussi faire
            //DictionnaireGenerique[2] = "autre type d'entree";

            //foreach(KeyValuePair<int,string> kvp in DictionnaireGenerique)
            //{
            //    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            //}
            #endregion

        }
    }
}
