using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SDMS.Utilities;

namespace SDMS.Models
{
    public class Student : EntityBase
    {
        
        [Required]
        // [StringLength(15, MinimumLength = 15)] 
        // String length check is not provided for simplicity
        public string CardNumber { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Name { get; set; }
        [Required]
        public byte[] Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Details { get; set; }
        public string Role { get; set; }
        public RegistrationStatus RegisterStatus { get; set; }
        public ICollection<CurrentCourseStudent> CurrentCourseStudents { get; set; }
        public ICollection<TakenCourseStudent> TakenCourseStudents { get; set; }
        public Guid SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public ICollection<Score> Marks { get; set; }
    }
}