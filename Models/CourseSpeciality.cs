using System;

namespace SDMS.Models
{
    public class CourseSpeciality
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
}