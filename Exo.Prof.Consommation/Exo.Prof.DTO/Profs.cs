using System;

namespace Exo.Prof.DTO
{
    public class Professor
    {
        public int professor_id { get; set; }
        public string professor_name { get; set; }
        public string professor_surname { get; set; }
        public int section_id { get; set; }
        public int professor_office { get; set; }
        public string professor_email { get; set; }
        public DateTime professor_hire_date { get; set; }
        public int professor_wage { get; set; }
    }
}
