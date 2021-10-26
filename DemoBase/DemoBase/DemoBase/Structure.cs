using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBase
{

    public enum Carburant { ESSENCE, DIESEL, LPG}

    struct Voiture
    {
        public string marque;
        public Carburant carburant;
    }

    struct Exemple
    {
        //accessibillité - type de retour - nom (paramètre)
        // tout ceci représente ce qu'on appel le prototype d'une méthode
        // nom et les paramètre, je parle de la signature de la méthode

        //une prcédure aura tjs pour type de retour void , elle ne fait qu'exécuter du code
        public void UneProcedure()
        {
            Console.WriteLine("Salut les Wad 21");
        }

        //une fonction possède un type de retour
        public string UneFonction()
        {
            Console.WriteLine("Quel est votre prénom  : ");
            string prenom = Console.ReadLine();
            
            return "Bonjour " + prenom;
        }

        public string EstMajeur()
        {
            int age = 18;
            if(age >= 18)
            {
                return "est majeur";
            }
            //else
            //{
            //    return "est mineur";
            //}
            return "est mineur";
        }

        public bool TheDoomGeneration(int age, bool MamanEstDaccord)
        {
            bool result = false;
            if(age >=16 || MamanEstDaccord)
            {
                result = true;
            }
            return result;
            
        }

        public void WarHammer40k(string armee)
        {
            Console.WriteLine($"je joue les {armee} à Warhamme 40k");
        }

        public void WarHammerAoS(string armee = "Nighthaunt")
        {
            Console.WriteLine($"je joue les {armee} à Warhamme Age of Sigmar");
        }

        public void JeVieilli(in int age)
        {
            // si je veux que la variable que je reçoit en paramètre de ma méthode ne soit pas modifiable je la pérécède 
            //du mot clé in
            //age++;
            Console.WriteLine(age);
        }

        public float Moyenne(params int[] notes)
        {
            float somme = 0;
            foreach(int note in notes)
            {
                somme += note;
            }
            return somme / notes.Length;
        }

        public float Moyenne(List<int> Notes)
        {
            float somme = 0;
            foreach (int note in Notes)
            {
                somme += note;
            }
            return somme / Notes.Count;
        }

        public void AfficheJeu()
        {
            Console.WriteLine("Je joue à Final Fantasy 14");
        }

        public void AfficheJeu(string jeu)
        {
            Console.WriteLine($"Je joue à {jeu}");
        }
        public void AfficheJeu(string jeu, string console)
        {
            Console.WriteLine($"Je joue à {jeu} sur {console}");
        }
        public void AfficheJeu(int prix)
        {
            Console.WriteLine($"Je joue à un jeu qui à coûté {prix} euros");
        }

     

    }
}
