using System;
using System.Collections.Generic;

namespace SDMS.Models.Dtos
{
    public class CourseReturnDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public int AbsenceLimit { get; set; }
        public string SyllabusPath { get; set; }
        public TeacherReturnDto Teacher { get; set; }
        public ICollection<TeacherReturnDto> Teachers { get; set; }
        public ICollection<CourseReturnDto> Prerequisites { get; set; }
    }
}