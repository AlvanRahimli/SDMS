using System;
using System.Collections.Generic;
using SDMS.Utilities;

namespace SDMS.Models.Dtos
{
    public class StudentReturnDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Details { get; set; }
        public Guid SpecialityId { get; set; }
        public string SpecialityName { get; set; }
        public RegistrationStatus RegisterStatus { get; set; }
        public List<CourseReturnDto> CurrentCourses { get; set; }
    }
}