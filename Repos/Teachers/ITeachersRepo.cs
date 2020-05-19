using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Teachers
{
    public interface ITeachersRepo
    {
        Task<RepoResponse<int>> EvaluateStudent(Guid sId, Guid cId, DateTime date, int score);
        Task<RepoResponse<int>> WriteAttendance(Guid sId, Guid cId, DateTime date);
        Task<RepoResponse<List<CourseReturnDto>>> LoadCourses(Guid tId);
    }
}