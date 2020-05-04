using System;

namespace SDMS.Models.Dtos
{
    public class AddAbsenceDto
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime DateTime { get; set; }
    }
}