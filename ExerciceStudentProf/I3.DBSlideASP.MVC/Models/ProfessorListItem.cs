using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3.DBSlideASP.MVC.Models
{
    public class ProfessorListItem
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Professor_ID { get; set; }
        public string Professor_Name { get; set; }
        public string Professor_Surname { get; set; }
        public int Section_ID { get; set; }
        //public int Professor_Office { get; set; }
        //public int Professor_Wage { get; set; }
    }
}
