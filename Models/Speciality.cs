using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Speciality : EntityBase
    {
        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<CourseSpeciality> CourseSpecialities { get; set; }
    }
}