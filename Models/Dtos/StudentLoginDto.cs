using System.ComponentModel.DataAnnotations;

namespace SDMS.Models.Dtos
{
    public class StudentLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}