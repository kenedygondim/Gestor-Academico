﻿using Gestor_Acadêmico.Context;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Gestor_Acadêmico.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string BirthDate { get; set; } = string.Empty;

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string Cpf { get; set; } = string.Empty;

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public string Address {  get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;

        public decimal GPA { get; private set; }

        public IEnumerable<StudentCourse> Courses { get; set; }

        public IEnumerable<StudentSubject> Subjects { get; set; }

        public IEnumerable<Grade> Grades { get; set; }

        public void CalcularGPA()
        {
            if (Grades != null && Grades.Any())
            {
                decimal somaNotas = Grades.Sum(g => g.Balance);
                decimal mediaNotas = somaNotas / Grades.Count();

                GPA = mediaNotas;

                return;
            }
                GPA = 0;
        }

        
    }
}
