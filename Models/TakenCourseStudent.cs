using System;

namespace SDMS.Models
{
    public class TakenCourseStudent
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CourseTeacherId { get; set; }
        public Teacher CourseTeacher { get; set; }
    }
}