using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Models
{
    public class Epargne : Compte
    {
        //variables de champs
        private DateTime _dernierRetrait;

        // propriétés
        public DateTime DernierRetrait
        {
            get
            {
                return _dernierRetrait;
            }

            private set
            {
            _dernierRetrait = value;   
            }
        }
        public override void Retrait(double Montant)
        {
            double AncienSolde = Solde;
            base.Retrait(Montant);

            if ( Solde != AncienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * 4.5 / 100; 
            
        }
    }
}
