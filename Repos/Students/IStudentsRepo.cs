using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SDMS.Models;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Students
{
    public interface IStudentsRepo
    {
        Task<RepoResponse<List<CourseReturnDto>>> LoadCoursesToChoose(Guid studentId);
        Task<RepoResponse<List<CourseReturnDto>>> LoadTakenCourses(Guid studentId);
        Task<RepoResponse<List<CourseReturnDto>>> LoadCurrentCourses(Guid studentId);
        Task<RepoResponse<List<CourseNameIdDto>>> ChooseCourses(Guid studentId,
            List<CourseNameIdDto> courses);
        Task<RepoResponse<List<Score>>> LoadScores(Guid studentId, Guid courseId,
            DateTime startDate, DateTime finishDate);
        Task<RepoResponse<List<Absence>>> LoadAttendances(Guid studentId, Guid courseId,
            DateTime startDate, DateTime finishDate);
    }
}