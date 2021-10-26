using System;

namespace CoursClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassVoyage voyage = new ClassVoyage();
            voyage.destination = "Italie";

            voyage.assignation_prix(57);

            Console.WriteLine(voyage.destination + " " + voyage.affichage_prix());
        }
    }
}
