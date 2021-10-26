using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Interface
{
    interface ICustomer
    {
        //le solde en lecture seule
        double Solde { get; }

        void Depot(double Montant);
        void Retrait(double Montant);

    }
}
