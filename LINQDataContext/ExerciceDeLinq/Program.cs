using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LINQDataContext;

namespace ExerciceDeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            DataContext dc = new DataContext();

            #region Exercices SELECT
            ////EXERCIE 2.1
            //var resultat1A = dc.Students.Select(c => new
            //{
            //    Prenom = c.First_Name,
            //    DateNaissance = c.BirthDate,
            //    c.Login,
            //    ResultatAnnee = c.Year_Result
            //});

            //// EXPRESSION DE REQUETE
            //var resultat1B = from s in dc.Students
            //                 select new { NomDeFamille = s.Last_Name, DateNaissance = s.BirthDate, s.Login, ResultatAnnuel = s.Year_Result };


            //foreach (var c in resultat1A) // ou resultat 1B
            //{
            //    Console.WriteLine($"{c.Prenom} - {c.DateNaissance} \n {c.Login} \n {c.ResultatAnnee}");
            //}

            ////EXERCICE 2.2
            //var Resultat2 = dc.Students.Select(c => new
            //{
            //    NomComplet = $"{c.First_Name} {c.Last_Name}",
            //    Id = c.Student_ID,
            //    DateNaissance = c.BirthDate,
            //});
            //foreach (var c in Resultat2)
            //{
            //    Console.WriteLine($"{c.NomComplet} - {c.Id} - {c.DateNaissance}");
            //} 

            //// EXPRESSION DE REQUETE
            //var resultat2B = from stu in dc.Students
            //                 select new { NomComplet = stu.Last_Name, DateNaissance = stu.BirthDate, stu.Login, ResultatAnnuel = stu.Year_Result };

            ////EXERCICE 2.3
            //var Resultat3 = dc.Students.Select(c => new
            //{
            //    Etudiant = $"{c.Student_ID} | {c.First_Name} | {c.Last_Name} | {c.BirthDate} | {c.Login} | {c.Section_ID} | {c.Year_Result} | {c.Course_ID}"
            //});
            //foreach (var c in Resultat3)
            //{
            //    Console.WriteLine($"{c.Etudiant}");
            //}

            //foreach (Student etudiant in dc.Students)
            //{
            //    Console.WriteLine($"{etudiant.Student_ID} | {etudiant.First_Name} | {etudiant.Last_Name} | {etudiant.BirthDate} | {etudiant.Login} | {etudiant.Section_ID} | {etudiant.Year_Result} | {etudiant.Course_ID}");
            //}

            ////EXERCICE 2.3 BIS
            //IEnumerable<string> Resulat3B = dc.Students.Select(etudiant => $"{etudiant.Student_ID} | {etudiant.First_Name} | {etudiant.Last_Name} | {etudiant.BirthDate} | {etudiant.Login} | {etudiant.Section_ID} | {etudiant.Year_Result} | {etudiant.Course_ID}");
            //foreach (string stu in Resulat3B)
            //{
            //    Console.WriteLine(stu);
            //}

            //EXPRESSION DE REQUETE
            //IEnumerable<string> Resultat3requete = from etudiant in dc.Students select $"{etudiant.Student_ID} | {etudiant.First_Name} | {etudiant.Last_Name} | {etudiant.BirthDate} | {etudiant.Login} | {etudiant.Section_ID} | {etudiant.Year_Result} | {etudiant.Course_ID}");

            #endregion

            #region Exercices WHERE
            ////EXERCICE 3.1
            ////Pour chaque étudiant né avant 1955, donner le nom, le résultat annuel et le statut. 
            ////Le statut prend la valeur « OK » si l’étudiant à obtenu au moins 12 comme résultat annuel et « KO » dans le cas contraire
            //
            //var Resultat3_1 = dc.Students.Where(etudiant => etudiant.BirthDate.Year < 1955)
            //                            .Select(stu => new {
            //                                stu.Last_Name,
            //                                stu.Year_Result,
            //                                statut = (stu.Year_Result < 12) ? "KO" : "OK"
            //                            });
            //foreach (var stu in Resultat3_1)
            //{
            //    Console.WriteLine($"{stu.Last_Name} {stu.Year_Result} {stu.statut}");
            //}

            //EXPRESSION REQUETE
            //var Resultat3_1B = from etudiant in dc.Students
            //                   where etudiant.BirthDate.Year < 1955
            //                   select new
            //                   {
            //                       etudiant.Last_Name,
            //                       etudiant.Year_Result,
            //                       statut = (etudiant.Year_Result < 12) ? "KO" : "OK"
            //                   };
            //foreach (var stu in Resultat3_1B)
            //{
            //    Console.WriteLine($"{stu.Last_Name} {stu.Year_Result} {stu.statut}");
            //}

            //EXERCICE 3.2
            //Donner pour chaque étudiant entre 1955 et 1965 le nom, le résultat annuel et la catégorie à laquelle il appartient.La catégorie est fonction du résultat annuel obtenu; un résultat inférieur à 10 appartient à la catégorie « inférieure », un résultat égal à 10 appartient à la catégorie « neutre », un résultat autre appartient à la catégorie « supérieure ».

            //var Resultat3_2 = dc.Students.Where(etudiant => etudiant.BirthDate.Year > 1955 && etudiant.BirthDate.Year < 1965)
            //                            .Select(etudiant => new {
            //                            etudiant.Last_Name,
            //                            etudiant.Year_Result,
            //                            categorie = (etudiant.Year_Result < 10) ? "inférieure" : (etudiant.Year_Result > 10) ? "supérieure" : "neutre"
            //                            });
            //foreach (var etudiant in Resultat3_2)
            //{
            //    Console.WriteLine($"{etudiant.Last_Name} {etudiant.Year_Result} {etudiant.categorie}");
            //}

            //EXERCICE 3.3
            //Ecrire une requête pour présenter le nom, l’id de section et de tous les étudiants qui ont un nom de famille qui termine par r.

            //var Resultat3_3 = dc.Students.Where(etudiant => etudiant.Last_Name.EndsWith("r"))
            //                            .Select(etudiant => new
            //                            {
            //                                etudiant.Last_Name,
            //                                etudiant.Section_ID
            //                            });
            //foreach(var etudiant in Resultat3_3)
            //{
            //    Console.WriteLine($"{etudiant.Last_Name} {etudiant.Section_ID}");
            //}

            //EXERCICE 3.4
            // Ecrire une requête pour présenter le nom et le résultat annuel classé par résultats annuels décroissant de tous les étudiants qui ont obtenu un résultat annuel inférieur ou égal à 3

            //var Resultat3_4 = dc.Students.Where(stu => stu.Year_Result <= 3)
            //                            .OrderByDescending(stu => stu.Year_Result)
            //                            .Select(etudiant => new
            //                            {
            //                                etudiant.Last_Name,
            //                                etudiant.Year_Result
            //                            });
            //foreach (var etudiant in Resultat3_4)
            //{
            //    Console.WriteLine($"{etudiant.Last_Name} {etudiant.Year_Result}");
            //}

            //EXERCICE 3.5 
            // Ecrire une requête pour présenter le nom complet (nom et prénom séparés par un espace) et le résultat annuel classé par nom croissant sur le nom de tous les étudiants appartenant à la section 1110

            //var Resultat3_5 = dc.Students.Where(etudiant => etudiant.Section_ID == 1110)
            //                            .OrderBy(etudiant => etudiant.Last_Name)
            //                            .Select(etudiant => new
            //{
            //    NomComplet = $"{etudiant.First_Name} {etudiant.Last_Name}",
            //    etudiant.Year_Result
            //});

            //foreach(var etudiant in Resultat3_5)
            //{
            //    Console.WriteLine($"{etudiant.NomComplet} {etudiant.Year_Result}");
            //}

            //EXERCICE 3.6
            //Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel classé par ordre croissant sur la section de tous les étudiants appartenant aux sections 1010 et 1020 ayant un résultat annuel qui n’est pas compris entre 12 et 18

            //var Resultat3_6 = dc.Students.Where(stud => stud.Section_ID == 1010 || stud.Section_ID == 1020)
            //                            .Where(stud => stud.Year_Result < 12 || stud.Year_Result > 18)
            //                            .OrderBy(stud => stud.Section_ID)
            //                            .Select(etudiant => new
            //                            {
            //                                etudiant.Last_Name,
            //                                etudiant.Section_ID,
            //                                etudiant.Year_Result
            //                            });
            //foreach (var etudiant in Resultat3_6)
            //{
            //    Console.WriteLine(etudiant.Last_Name + " " + etudiant.Section_ID + " " + etudiant.Year_Result);
            //}

            //EXERCICE 3.7
            //Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel sur 100(nommer la colonne ‘result_100’) classé par ordre décroissant du résultat de tous les étudiants appartenant aux sections commençant par 13 et ayant un résultat annuel sur 100 inférieur ou égal à 60.

            //var Resultat3_7 = dc.Students
            //    .Where(etudiant => etudiant.Section_ID.ToString().StartsWith("13"))
            //    .Where(etudiant => etudiant.Year_Result*5 <= 60)
            //    .OrderByDescending(etudiant => etudiant.Year_Result)
            //    .Select(etudiant => new
            //{
            //    etudiant.Last_Name,
            //    etudiant.Section_ID,
            //    result_100 = etudiant.Year_Result * 5
            //});

            //foreach(var etudiant in Resultat3_7)
            //{
            //    Console.WriteLine($"{etudiant.Last_Name} {etudiant.Section_ID} {etudiant.result_100}/100");
            //}
            #endregion

            #region « Count », « Min », « Max », « Sum » et « Average »
            ////EXERCICE 4.1 - Donner le résultat annuel moyen pour l’ensemble des étudiants.
            //Console.WriteLine("Moyenne : " + dc.Students.Average(etudiant => etudiant.Year_Result));
            ////EXERCICE 4.2 - Donner le plus haut résultat annuel obtenu par un étudiant
            //Console.WriteLine("Max : " + dc.Students.Max(etudiant => etudiant.Year_Result));
            ////EXERCICE 4.3 - Donner la somme des résultats annuels
            //Console.WriteLine("Somme : " + dc.Students.Sum(etudiant => etudiant.Year_Result));
            ////EXERCICE 4.4 - Donner le résultat annuel le plus faible
            //Console.WriteLine("Min : " + dc.Students.Min(etudiant => etudiant.Year_Result));
            ////EXERCICE 4.5 Donner le nombre de lignes qui composent la séquence « Students » ayant obtenu un résultat annuel impair.
            //Console.WriteLine("Count impair : " +  dc.Students.Count(etudiant => etudiant.Year_Result % 2 == 1));


            #endregion

            #region GROUP BY, JOIN, GROUPJOIN
            // Exercice 5.1
            // Donner pour chaque section, le résultat maximum(« Max_Result ») obtenu par les étudiants.
            var Resultat5_1 = dc.Students.GroupBy(group => group.Section_ID)
                .OrderBy(ordre => ordre.Key);
            foreach(var group in Resultat5_1)
            {
                Console.WriteLine("Section : " + group.Key + " Max = " + group.Max(max => max.Year_Result));
            }

            // Exercice 5.2 Donner pour toutes les sections commençant par 10, le résultat annuel moyen(« AVGResult ») obtenu par les étudiants.
            // Exercice 5.3 Donner le résultat moyen(« AVGResult ») et le mois en chiffre(« BirthMonth ») pour les étudiants né le même mois entre 1970 et 1985.
            // Exercice 5.4 Donner pour toutes les sections qui compte plus de 3 étudiants, la moyenne des résultats annuels(« AVGResult »).
            // Exercice 5.5 Donner pour chaque cours, le nom du professeur responsable ainsi que la section dont le professeur fait partie.

            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}
