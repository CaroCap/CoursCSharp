using GestBank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Models
{
    public abstract class Compte : IBanker
    {
        private string _numero;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get { return _numero; }
            private set { _numero = value; }
        }

        public double Solde
        {
            get { return _solde; }
            private set { _solde = value; }
        }

        public Personne Titulaire
        {
            get { return _titulaire; }
            private set { _titulaire = value; }
        }

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire; 
        }
        public Compte(string numero, Personne titulaire, double solde)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
        }


        public void Depot(double Montant)
        {
            if(Montant <= 0)
            {
                return; //à remplacer par une exception
            }
            Solde += Montant;
        }

        //je crée une méthode retrait que je pourrai ré-écrire dans les classes enfant si besoint
        public virtual void Retrait(double Montant)
        {
            //elle fait appelle à une méthode retrait surchargée prenant deux paramètres
            //le montant et la ligne de crédit que je met à 0 ici car le compte épargne n'a pas de ligne de crédit
            Retrait(Montant, 0.0);
        }

        //la méthode surchargée retrait est placée en protected pour pouvoir être utilisée ici et dans les classes enfants de compte
        protected void Retrait(double Montant, double LigneDeCredit)
        {
            if (Montant <= 0)
            {
                Console.WriteLine("Le montant ne peut être inférieur à 0");
                return; //à remplacer par une exception
            }
            if(Solde - Montant < -LigneDeCredit)
            {
                Console.WriteLine("Je suis sous la ligne de crédit");
                return; //à remplacer par une exception
            }
            Solde -= Montant;
        }

        protected abstract double CalculInteret();
        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        
    }
}
