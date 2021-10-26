using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Heritage_polymorphisme
{
    //le mot clé sealed fait que peersonne ne peut hériter de cette class
    public /*sealed*/ class Maman : Personne
    {
        public bool AimeLesChats { get; set; }

        //le mot clé virtual me permet de ré-écrire/redéfinir la méthode dans la classe enfant
        public virtual void LireUnLivre()
        {
            Console.WriteLine("Le trail pour les débutants");
        }

        public virtual string Boire(string boisson)
        {
            return "J'aime boire " + boisson;
        }

        public void SetGame(string jeu) 
        {
            JeuPréféré = jeu;
        }

        public string GetGame()
        {
            return JeuPréféré;
        }
    }
}
