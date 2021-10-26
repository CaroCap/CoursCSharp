using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFilm.models
{
    public class Realisateur : Personne
    {
        public void AfficheFilm()
        {
            Console.WriteLine($"{Nom} a réalisé pleins de films");
        }

        public override string Manger()
        {
            return base.Manger() + " pendant que je travaille";
        }
    }
}
