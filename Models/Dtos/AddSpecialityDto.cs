using System;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models.Dtos
{
    public class AddSpecialityDto
    {
        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}