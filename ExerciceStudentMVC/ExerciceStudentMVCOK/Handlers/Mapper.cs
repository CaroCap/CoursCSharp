using DBSlideDataContext.DTO;
using ExerciceStudentMVCOK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciceStudentMVCOK.Handlers
{
    public static class Mapper
    {
        public static StudentListItem ToListItem(this Student student)
        {
            if (student is null) return null;
            return new StudentListItem
            {
                Id = student.Student_ID,
                Nom = student.Last_Name,
                Prenom = student.First_Name,
                Section_id = student.Section_ID
            };
        }

        public static StudentDetails ToDetails (this Student student)
        {
            if (student is null) return null;
            return new StudentDetails
            {
                Id = student.Student_ID,
                Nom = student.Last_Name,
                Prenom = student.First_Name,
                Section_id = student.Section_ID,
                DateNaissance = student.BirthDate,
                Identifiant = student.Login,
                ResultatAnnuel = student.Year_Result,
                Course_id = student.Course_ID
            };
        }

        public static Student ToDTO(this StudentAddForm form) 
        {
            if (form is null) return null;
            return new Student
            {
                First_Name = form.Prenom,
                Last_Name = form.Nom,
                BirthDate = form.DateNaissance,
                Section_ID = form.Section_id,
                Course_ID = form.Course_id,
                Year_Result = form.ResultatAnnuel,
                Login = form.Identifiant
            };
        }
    }
}
