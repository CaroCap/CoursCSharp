using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Heritage_polymorphisme
{
    
    //par défaut une classe est de niveau d'accès privé
    //pour l'utiliser endehors deu namaspace je dois la définir à public
    public class Personne
    {
        //une classe c'est la description d'un objet, son plan de construction
        //quand je parle de classe , c'est quand je décris
        //quand je parle d'objet c'est quand j'ai en mémoire un élément qui a été créé à partir du plan
        private string _nom, _prenom;
        private DateTime _birthDate;

        public string Nom
        {
            //permet de faire l'affichage de l'information sans créer de méthode supplémentaire
            get { return _nom; }
            //permet de définir la valeur que j'attribue à la propriété
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                if ((DateTime.Now.Year - value.Year) > 18)
                {
                    _birthDate = value;
                }
            }
        }

        //prop ou propfull suivi de deux tabulation -> raccourci d'écriture pour générer les propriétés
        protected string JeuPréféré { get; set; }

        public void parler(string phrase)
        {
            Console.WriteLine(phrase);
        }
    }
}
