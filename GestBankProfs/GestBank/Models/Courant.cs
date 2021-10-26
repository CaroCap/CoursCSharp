using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestBank.Models
{

    public class Courant : Compte
    {
        //champs
        //private string _numero;
        //private double _solde;
        //private Personne _titulaire;
        private double _ligneDeCredit;

        //public string Numero
        //{
        //    get { return _numero;}
        //    set { _numero = value;}
        //}

        //public double Solde
        //{
        //    get { return _solde;}
        //    private set { _solde = value;}
        //}

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set
            {
                //if (value >= 0)
                //{
                //    _ligneDeCredit = value;
                //}
                //else
                //{
                //    Console.WriteLine("La ligne de credit doit être supérieur ou égal à 0");
                //    // à remplacer plus tard par une exception
                //}
                if(value < 0)
                {
                    Console.WriteLine("La ligne de credit doit être supérieur ou égal à 0");
                    return;// à remplacer plus tard par une exception
                }
                _ligneDeCredit = value;

            }
        }

        public Courant(string numero, Personne titulaire) : base(numero,titulaire)
        {

        }
      
        public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {

        }

        public Courant(string numero, Personne titulaire, double solde, double ligneCredit) : base(numero, titulaire, solde)
        {
            LigneDeCredit = ligneCredit;
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
        //    //je vérifie que mon solde moins le montant n'est pas plus petit que ma ligne de crédit négative 
        //    if (Solde - Montant < -LigneDeCredit)
        //    {
        //        Console.WriteLine("Je suis sous la ligne de crédit");
        //        return; //à remplacer plus tard par une exception;
        //    }
        //    Solde -= Montant;
        //}

        //public void Depot(double Montant)
        //{
        //    if(Montant <= 0)
        //    {
        //        Console.WriteLine("Le montant ne peut être inférieur à 0");
        //        return; //à remplacer plus tard par une exception;
        //    }
        //    Solde += Montant;
        //}

        //je ré-écrit la méthode retrait pour du compte pour qu'elle corresponde au besoin de courant
        public override void Retrait(double Montant)
        {
            //dans ce cas ci la ligne de crédit est définie, je la passe en paramètre de la méthode surchargée.
            Retrait(Montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            if(Solde < 0)
            {
                return (Solde / 100) * 9.75;
            }
            else
            {
                return (Solde / 100) * 3;
            }
            //la version en ternaire
            //return (Solde < 0) ? Solde * 0.0975 : Solde * 0.03;
        }
    }
}
