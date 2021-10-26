using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Heritage_polymorphisme
{
    public class Papa : Personne
    {
        public bool AimeLesJeuxdeSociétés { get; set; }

        public void JoueAuVolley()
        {
            Console.WriteLine("Entrainement ce soir");
        }
    }
}
