using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Models
{
    public abstract class Compte
    {
        //variables de champs
        private string _numero;
        private double _solde;
        private Personne _titulaire;

        // propriétés
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public double Solde
        {
            get { return _solde; }
            private set { _solde = value; } //lecture seule
        }

        public Personne Titulaire { get { return _titulaire; } set { _titulaire = value; } }

        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0.0);
        }

        protected void Retrait (double Montant, double LigneDeCredit)
        {
            if (Montant <= 0)
            {
                Console.WriteLine("Le montant ne peut pas être inférieur à 0");
                return; // à remplacer par une exception
            }
            if (Solde - Montant < -LigneDeCredit)
            {
                Console.WriteLine("Vous avez atteint la limite de la Ligne de Crédit");
                return; // à remplacer par une exception
            }
            Solde -= Montant;
        }
       

        public void Depot(double Montant)
        {
            if (Montant <= 0)
            {
                Console.WriteLine("Le montant déposé ne peut pas être inférieur à 0");
                return; // à remplacer plus tard par une exception
            }
            Solde += Montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();   
        }
    }
}
