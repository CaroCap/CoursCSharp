using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Models
{
    public class ProfessorCreateForm
    {
        [Required]
        [DisplayName("Nom")]
        public string Professor_Name { get; set; }
        [Required]
        [DisplayName("Prénom")]
        public string Professor_Surname { get; set; }
        [Required]
        [DisplayName("Identifiant de Section")]
        public int Section_ID { get; set; }
        [Required]
        [DisplayName("Bureau")]
        public int Professor_Office { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "L'adresse n'est au bon format.")]
        [DisplayName("Email")]
        public string Professor_Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Professor_HireDate { get; set; }
        [Required]
        [DisplayName("Salaire")]
        public int Professor_Wage { get; set; }
    }
}
