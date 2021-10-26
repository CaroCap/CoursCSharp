using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursClass
{
    public class ClassVoyage // préciser public pour qu'il soit accessible dans les autres programmes du même namespace
    {
        public string destination;
        private double _prix;

        // Accesseur - GET => pour atteindre le prix qui est en private
        public double affichage_prix()
        {
            return _prix;
        }

        // Mutateur - SET pour définir la valeur du prix 
        public void assignation_prix(double valeur)
        {
            _prix = valeur;
        }

        
    }
}
