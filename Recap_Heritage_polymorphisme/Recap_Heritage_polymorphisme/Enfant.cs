using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Heritage_polymorphisme
{
    public class Enfant : Maman
    {
        public void Jouer(string jeu)
        {
            Console.WriteLine($"Je joue avec {jeu}");
        }

        public override void LireUnLivre()
        {
            Console.WriteLine("5 Minutes pour s'endormir");
        }

        public override string Boire(string boisson)
        {
            return base.Boire(boisson) + " parce que maman aime ça";
        }

        
    }
}
