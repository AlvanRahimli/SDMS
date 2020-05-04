using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDMS.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 10)]
        public int Credit { get; set; }
        public int AbsenceLimit { get; set; }
        public string SyllabusPath { get; set; }
        public Guid? RequiredById { get; set; }
        public Course RequiredBy { get; set; }
        public ICollection<Course> Prerequisites { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<CourseSpeciality> CourseSpecialities { get; set; }
        public ICollection<TakenCourseStudent> TakenCourseStudents { get; set; }
        public ICollection<CurrentCourseStudent> CurrentCourseStudents { get; set; }
    }
}