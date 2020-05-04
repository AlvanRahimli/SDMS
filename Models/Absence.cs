using System;

namespace SDMS.Models
{
    public class Absence : EntityBase
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime DateTime { get; set; }
    }
}