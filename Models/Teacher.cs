using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SDMS.Utilities;

namespace SDMS.Models
{
    public class Teacher : EntityBase
    {
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Name { get; set; }
        [Required]
        // [StringLength(15, MinimumLength = 15)]
        public string CardNumber { get; set; }
        [Required]
        public byte[] Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string Details { get; set; }
        public string CVPath { get; set; }
        public string Role { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<Course> Courses { get; set; }
        public RegistrationStatus RegisterStatus { get; set; }
    }
}