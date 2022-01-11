using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Models
{
    public class DiffusionDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }

        [DataType("datetime-local")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}")]
        [DisplayName("Date de diffusion")]
        public DateTime DateDiffusion { get; set; }

        public string Titre { get; set; }

        [ScaffoldColumn(false)]
        public int Film_id { get; set; }

        [ScaffoldColumn(false)]
        public int Cinema_id { get; set; }

    }
}
