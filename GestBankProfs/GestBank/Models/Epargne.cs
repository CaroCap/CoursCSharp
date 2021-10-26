using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Models
{
    public class Epargne : Compte
    {
        //variable de champs
        //private string _numero;
        //private double _solde;
        private DateTime _dernierRetrait;
        //private Personne _titulaire;

        //propriétés
        //public string Numero
        //{
        //    get { return _numero; }
        //    set { _numero = value; }
        //}
        //public double Solde
        //{
        //    get { return _solde; }
        //    private set { _solde = value; }
        //}
        public DateTime DernierRetrait
        {
            get { return _dernierRetrait; }
            private set { _dernierRetrait = value; }
        }

        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {

        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {

        }

        //public Personne Titulaire
        //{
        //    get { return _titulaire; }
        //    set { _titulaire = value; }
        //}

        //public void Retrait(double Montant)
        //{
        //    if (Montant <= 0)
        //    {
        //        Console.WriteLine("Le montant ne peut être inférieur à 0");
        //        return; //à remplacer plus tard par une exception;
        //    }
        //    if (Solde - Montant < 0)
        //    {
        //        Console.WriteLine("y a plus assez de sous pour retirer autant");
        //        return; //à remplacer plus tard par une exception;
        //    }
        //    Solde -= Montant;
        //    DernierRetrait = DateTime.Now;
        //}

        //public void Depot(double Montant)
        //{
        //    if (Montant <= 0)
        //    {
        //        Console.WriteLine("Le montant ne peut être inférieur à 0");
        //        return; //à remplacer plus tard par une exception;
        //    }
        //    Solde += Montant;
        //}

        //je ré-écris la méthode retrait pour qu'elle coressponde au besoin d'épargne
        public override void Retrait(double Montant)
        {
            //je stock la valeur du solde actuel
            double AncienSolde = Solde;
            //j'appel la méthode de base Retrait de la classe parent
            base.Retrait(Montant);

            //je vérifie si le nouveau solde est différent de l'ancien, si oui je modifie la date de dernier retrait
            if(Solde != AncienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            //return (Solde/100)*4.5;
            return Solde * 0.045;
        }
    }
}
