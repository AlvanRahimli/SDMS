using System.ComponentModel.DataAnnotations;
using SDMS.Utilities;

namespace SDMS.Models
{
    public class Admin : EntityBase
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public byte[] Password { get; set; }
        public RegistrationStatus RegistrtationStatus { get; set; }
    }
}