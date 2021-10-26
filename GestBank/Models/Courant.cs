using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestBank.Models;

namespace GestBank
{
    public class Courant : Compte
    { 
        private double _ligneDeCredit;
        
        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("La ligne de crédit doit être supérieure ou égale à 0");
                    return; // à remplacer plus tard par une exception
                }
                    _ligneDeCredit = value; 
            }
        }

        //public void Retrait(double Montant)
        //{
        //    if (Montant <= 0)
        //    {
        //        Console.WriteLine("Le montant ne peut pas être inférieur à 0");
        //        return; // à remplacer plus tard par une exception
        //    }

        //    if (Solde - Montant < -LigneDeCredit) // on vérifie que le solde - le montant n'est pas < à la ligne de crédit négative
        //    {
        //        Console.WriteLine("Vous avez atteint la limite de la Ligne de Crédit");
        //        return; // à remplacer plus tard par une exception
        //    }
        //    Solde = Solde - Montant;
        public override void Retrait(double Montant)
        {
            Retrait(Montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            if (Solde > 0)
            {
                return Solde * 3 / 100;            
            }
            return Solde * 9.75 / 100;
            // OU ternaire
            //return (Solde <0) ? Solde * 0.0975 : Solde $ 0.03;
        }
    }
}
