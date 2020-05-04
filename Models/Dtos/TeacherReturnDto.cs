using System;
using System.Collections.Generic;
using SDMS.Utilities;

namespace SDMS.Models.Dtos
{
    public class TeacherReturnDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Details { get; set; }
        public string CVPath { get; set; }
        public string CardNumber { get; set; }
        public RegistrationStatus RegisterStatus { get; set; }
        public List<CourseReturnDto> Courses { get; set; }
    }
}