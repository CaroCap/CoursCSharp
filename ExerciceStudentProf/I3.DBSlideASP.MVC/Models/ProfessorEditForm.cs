using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Models
{
    public class ProfessorEditForm
    {
        [ScaffoldColumn(false)]
        [DisplayName("Prénom")]
        public string Professor_Name { get; set; }
        
        [ScaffoldColumn(false)]
        [DisplayName("Nom")]
        public string Professor_Surname { get; set; }

        [Required]
        [DisplayName("Bureau")]
        public int Professor_Office { get; set; }

        [Required]
        [DisplayName("Salaire")]
        public int Professor_Wage { get; set; }
    }
}
