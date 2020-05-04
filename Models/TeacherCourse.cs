using System;

namespace SDMS.Models
{
    public class TeacherCourse
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
