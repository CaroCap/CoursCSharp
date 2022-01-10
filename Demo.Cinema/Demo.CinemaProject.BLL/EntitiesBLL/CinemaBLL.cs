using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.CinemaProject.BLL.EntitiesBLL
{
    public class CinemaBLL
    {
        // Les mêmes propriétés que celles du DAL
        public string Nom { get; set; }
        public string Ville { get; set; }
        public int Id { get; set; }

        //Propriétés supplémentaire que dans le DAL
        public IEnumerable<DiffusionBLL> Diffusions { get; set; }

        // Constructeur 
        public CinemaBLL(int id, string nom, string ville)
        {
            Id = id;
            Nom = nom;
            Ville = ville;
        }

        // Méthode
        public void AddDiffusion(DateTime dateDiffusion, FilmBLL film)
        {
            throw new NotImplementedException();
        }

        public void CancelDiffusion()
        {
            throw new NotImplementedException();
        }
    }
}
