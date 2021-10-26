using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFilm.models
{
    public class Acteur : Personne
    {
        public void AfficheFilm()
        {
            Console.WriteLine("Je suis à l'affiche de pleins de films");
        }

        public override string Manger()
        {
            return base.Manger() + " parce que c'est gratuit et que je m'ennuie";
        }
    }
}
