using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciceStudentMVCOK.Models
{
    public class StudentAddForm
    {
        //Ces propriétés servent à récupérer les données du formulaire (Nom, Prenom, Section_id, Course_id, DateNaissance, ResultatAnnuel)
        //Les propriétés IEnumerable serviront à l'affichage des option dans la view (Courses_IDs et Sections_IDs)
        [Required(ErrorMessage = "Le Nom est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le Nom doit contenir entre 2 et 16 caractères.")]
        [MaxLength(16, ErrorMessage = "Le Nom doit contenir entre 2 et 16 caractères.")]
        [DisplayName("Nom : ")]
        [DataType(DataType.Text)]
        public string Nom { get; set; }
        //par convention on met une majuscule au nom de priorité

        [Required(ErrorMessage = "Le Prenom est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le Prenom doit contenir entre 2 et 16 caractères.")]
        [MaxLength(16, ErrorMessage = "Le Prenom doit contenir entre 2 et 16 caractères.")]
        [DisplayName("Prénom : ")]
        [DataType(DataType.Text)]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'ID de section est obligatoire.")]
        public int Section_id { get; set; }
        [DisplayName("Section ID : ")]
        public IEnumerable<int> Sections_IDs { get; set; }
        //IEnumerable sert pour l'affichage des options du Select dans la view

        [Required(ErrorMessage = "L'ID du Cours est obligatoire.")]
        public string Course_id { get; set; }
        [DisplayName("Course ID : ")]
        //IEnumerable sert pour l'affichage des options du Select dans la view
        public IEnumerable<string> Courses_IDs { get; set; }


        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        [DisplayName("Date de Naissance : ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateNaissance { get; set; }
        // Vu qu'on utilise l'age uniquement pour vérifier la majorité pas besoin dans le model et direct dans le controller pour la validation
        //public int Age{
        //    get {return DateTime.Now.Year - this.DateNaissance.Year;}
        //}

        [Required(ErrorMessage = "Le Résultat annuel est obligatoire.")]
        [Range(0, 20, ErrorMessage = "Le Résultat annuel doit être compris entre 0 et 20.")]
        [DisplayName("Résultat Annuel : ")]
        //[DataType(DataType.)]
        public ushort ResultatAnnuel { get; set; }
        //ResultatAnnuel pourrait être int mais ushort (65535 max) est plus correct même si souvent délaissé


        //Besoin pour le mapper
        public string Identifiant { get
            { 
                if (string.IsNullOrWhiteSpace(this.Nom) || string.IsNullOrWhiteSpace(this.Prenom)) throw new FormatException();
                return this.Prenom[0] + this.Nom.Substring(0, 3).Replace(" ", ".");
            }
        }
    }
}

                //Id = student.Student_ID,
                //Section_id = student.Section_ID,
                //DateNaissance = student.BirthDate,
                //Identifiant = student.Login,
                //ResultatAnnuel = student.Year_Result,
                //Course_id = student.Course_ID
