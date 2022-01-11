using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Models
{
    public class CinemaListItem
    {
        [ScaffoldColumn(false)] // Pour que ça ne soit pas générer automatiquement dans ma vue
        [Key] // Pour préciser que c'est ma clef primaire
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
    }
}
