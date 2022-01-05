using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Models
{
    public class ProfessorDeleteForm
    {
        [DisplayName("Nom de famille")]
        public string Professor_Name { get; set; }
        [DisplayName("Prénom")]
        public string Professor_Surname { get; set; }
        [Required]
        [DisplayName("Êtes-vous sûr de vouloir supprimer cet étudiant?")]
        public bool Validate { get; set; }
    }
}
