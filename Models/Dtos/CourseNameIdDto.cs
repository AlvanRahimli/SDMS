using System;

namespace SDMS.Models.Dtos
{
    public class CourseNameIdDto
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public Guid TeacherId { get; set; }
    }
}