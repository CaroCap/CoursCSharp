using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciceStudentMVCOK.Models
{
    public class StudentAddForm
    {
        [Required(ErrorMessage = "L'adresse email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'adresse n'est au bon format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\S+$).{8,20}$", ErrorMessage = "Le mot de passe doit au minimum un nombre, une minuscule, une majuscule, un caractère parmis '@#$%^&-+=()', aucun espace blanc, compris entre 8 et 20 caractères.")]
        public string Passwd { get; set; }
    }
}

                //Id = student.Student_ID,
                //Nom = student.Last_Name,
                //Prenom = student.First_Name,
                //Section_id = student.Section_ID,
                //DateNaissance = student.BirthDate,
                //Identifiant = student.Login,
                //ResultatAnnuel = student.Year_Result,
                //Course_id = student.Course_ID
