using GestBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Interface
{
    interface IBanker : ICustomer
    {
        //titulaire en lecture seule
        Personne Titulaire { get; }
        //le numéro en lecture seule
        string Numero { get; }

        void AppliquerInteret();
    }
}
