using System;
using System.ComponentModel.DataAnnotations;
using SDMS.Utilities;

namespace SDMS.Models.Dtos
{
    public class StudentRegisterDto
    {
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Name { get; set; }
        [Required]
        // [StringLength(15, MinimumLength = 15)] 
        // String length check is not provided for simplicity
        public string CardNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public Guid SpecialityId { get; set; }
    }
}