using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFilm.models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual string Manger()
        {
            return "J'aime manger";
        }
    }
}
