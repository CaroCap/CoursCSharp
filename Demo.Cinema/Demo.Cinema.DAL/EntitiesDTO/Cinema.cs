//On supprime les using pour que ce soit très simple
//using System;
//using System.Collections.Generic;
//using System.Text;

namespace Demo.CinemaProject.DAL.EntitiesDTO
{
    //ne pas oublier de rendre la classe public
    public class Cinema
    {
        //on décrit les colonnes de la table cinema
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
    }
}
