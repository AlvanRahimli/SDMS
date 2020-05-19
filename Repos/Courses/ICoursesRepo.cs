using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Courses
{
    public interface ICoursesRepo
    {
        Task<RepoResponse<List<StudentReturnDto>>> GetStudentListWTeacher(Guid cId, Guid tId);
        Task<RepoResponse<List<StudentReturnDto>>> GetStudentList(Guid cId);
        Task<RepoResponse<List<CourseReturnDto>>> GetCourses();
        Task<RepoResponse<List<TeacherCourseAddDto>>> GetCoursesBrief();
        Task<RepoResponse<List<TeacherCourseAddDto>>> GetCoursesBrief(Guid tId);
        Task<RepoResponse<CourseReturnDto>> GetCourse(Guid cId);
    }
}