using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Models
{
    public class CinemaDetails // On évite l'héritage sur les Model Vue
    {
        [ScaffoldColumn(false)] // Pour que ça ne soit pas générer automatiquement dans ma vue
        [Key] // Pour préciser que c'est ma clef primaire
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        public IEnumerable<DiffusionDetails> Diffusions { get; set; } // Pour voir les horaires de diffusion
    }
}
