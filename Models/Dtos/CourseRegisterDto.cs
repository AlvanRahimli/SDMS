using System;

namespace SDMS.Models.Dtos
{
    public class CourseRegisterDto
    {
        public string Name { get; set; }
        public int Credit { get; set; }
        public int AbsenceLimit { get; set; }
        public string SyllabusPath { get; set; }
        public Guid TeacherId { get; set; }
    }
}