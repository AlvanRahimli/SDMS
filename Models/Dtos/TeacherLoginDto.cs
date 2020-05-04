using System.ComponentModel.DataAnnotations;

namespace SDMS.Models.Dtos
{
    public class TeacherLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
    }
}