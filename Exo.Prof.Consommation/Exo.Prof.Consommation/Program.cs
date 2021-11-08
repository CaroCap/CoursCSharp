using System;
using Exo.Prof.DTO;
using Exo.Prof.DAO;
using System.Collections.Generic;

namespace Exo.Prof.Consommation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello les Profs!");
            
            ProfService service = new ProfService();
            Console.WriteLine("Liste Profs \n");
            IEnumerable<Professor> profs = service.Get();
            foreach (Professor prof in profs)
            {
                Console.WriteLine($"{prof.professor_id} {prof.professor_name} {prof.professor_surname}");
            }
        }
    }
}
