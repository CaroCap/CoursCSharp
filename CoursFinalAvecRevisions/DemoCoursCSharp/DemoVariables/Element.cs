using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVariables
{
    // Définition d'un objet Elément
    class Element
    {
        // Propriété = caractéristique que l'objet Elément
        public string Message = "Message global";

        // Fonctionnalité de l'objet Elément
        public void Afficher()
        {
            string Message = "Message local";
            Console.WriteLine(Message);

            // this pour appeler l'élément courant (l'objet) pour
            // acceder à ses caractéristiques (Message)
            Console.WriteLine(this.Message);
            // Affecter nouvelle valeur à la variable globale
            this.Message = "Nouveau message global";
            Console.WriteLine(this.Message);

            const int CONST_LOCALE = 15;
        }
    }
}
