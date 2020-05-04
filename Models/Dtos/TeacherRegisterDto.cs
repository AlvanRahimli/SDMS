using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SDMS.Utilities;

namespace SDMS.Models.Dtos
{
    public class TeacherRegisterDto
    {
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Details { get; set; }
        public string CVPath { get; set; }
        [Required]
        // [StringLength(15, MinimumLength = 15)] 
        // String length check is not provided for simplicity
        public string CardNumber { get; set; }
        public ICollection<Guid> CourseIds { get; set; }
    }
}