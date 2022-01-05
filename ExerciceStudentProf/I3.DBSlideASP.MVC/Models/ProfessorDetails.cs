using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Models
{
    public class ProfessorDetails
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Professor_ID { get; set; }

        [DisplayName("Nom")]
        public string Professor_Name { get; set; }

        [DisplayName("Prénom")]
        public string Professor_Surname { get; set; }

        [DisplayName("Identifiant de la Section")]
        public int Section_ID { get; set; }

        [DisplayName("Bureau")]
        public int Professor_Office { get; set; }

        [EmailAddress(ErrorMessage = "L'adresse n'est au bon format.")]
        [DisplayName("Email")]
        public string Professor_Email { get; set; }

        [DisplayName("Date d'engagement")]
        [DataType(DataType.Date)]
        public DateTime Professor_HireDate { get; set; }

        [DisplayName("Salaire")]
        public int Professor_Wage { get; set; }
    }
}
