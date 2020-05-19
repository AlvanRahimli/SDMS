using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SDMS.Data;
using SDMS.Models;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Teachers
{
    public class TeachersRepo : ITeachersRepo
    {
        private readonly SDMSContext _context;
        private readonly IConfiguration _config;

        public TeachersRepo(SDMSContext context, IConfiguration config)
        {
            this._context = context;
            this._config = config;
        }

        public async Task<RepoResponse<int>> EvaluateStudent(Guid sId, Guid cId, 
            DateTime date, int score)
        {
            var student = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(ccs => ccs.Course)
                .Include(ccs => ccs.Student)
                .FirstOrDefaultAsync(ccs => ccs.StudentId == sId && ccs.CourseId == cId);
            
            if (student == null)
            {
                return new RepoResponse<int>()
                {
                    IsSuccess = false,
                    Content = 0,
                    Message = _config["ErrorCodes:student_course"]
                };
            }

            var newScore = new Score()
            {
                Id = Guid.NewGuid(),
                CourseId = student.CourseId,
                StudentId = student.StudentId,
                Date = date,
                ScoreOver100 = score
            };

            await _context.Scores.AddAsync(newScore);
            var dbResult = await _context.SaveChangesAsync();

            if (dbResult > 0)
            {
                return new RepoResponse<int>()
                {
                    Content = dbResult,
                    IsSuccess = true,
                    Message = _config["SuccessCodes:created"]
                };
            }
            return new RepoResponse<int>()
            {
                IsSuccess = false,
                Content = 0,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public async Task<RepoResponse<int>> WriteAttendance(Guid sId, Guid cId, DateTime date)
        {
            var student = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(ccs => ccs.Course)
                .Include(ccs => ccs.Student)
                .FirstOrDefaultAsync(ccs => ccs.StudentId == sId && ccs.CourseId == cId);
            
            if (student == null)
            {
                return new RepoResponse<int>()
                {
                    IsSuccess = false,
                    Content = 0,
                    Message = _config["ErrorCodes:student_course"]
                };
            }

            var oldAbsence = await _context.Absences
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.CourseId == cId && a.StudentId == sId
                    && a.DateTime.Day == date.Day);
            if (oldAbsence != null)
            {
                return new RepoResponse<int>()
                {
                    Content = 0, 
                    IsSuccess = false,
                    Message = _config["ErrorCodes:record_exists"]
                };
            }

            var newAbsence = new Absence()
            {
                Id = Guid.NewGuid(),
                CourseId = student.CourseId,
                StudentId = student.StudentId,
                DateTime = date
            };

            await _context.Absences.AddAsync(newAbsence);
            var dbResult = await _context.SaveChangesAsync();

            if (dbResult > 0)
            {
                return new RepoResponse<int>()
                {
                    Content = dbResult,
                    IsSuccess = true,
                    Message = _config["SuccessCodes:created"]
                };
            }
            return new RepoResponse<int>()
            {
                IsSuccess = false,
                Content = 0,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public async Task<RepoResponse<List<CourseReturnDto>>> LoadCourses(Guid tId)
        {
            var courses = await _context.TeacherCourses
                .AsNoTracking()
                .Include(tc => tc.Course)
                .Include(tc => tc.Teacher)
                .Where(tc => tc.TeacherId == tId)
                .Select(tc => new CourseReturnDto()
                {
                    Id = tc.CourseId,
                    AbsenceLimit = tc.Course.AbsenceLimit,
                    Credit = tc.Course.Credit,
                    Name = tc.Course.Name,
                    SyllabusPath = tc.Course.SyllabusPath
                }).ToListAsync();
            
            if (courses == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:teacher_course"]
                };
            }

            return new RepoResponse<List<CourseReturnDto>>()
            {
                Content = courses,
                IsSuccess = true,
                Message = _config["SuccessCodes:found"]
            };
        }

        //TODO Write this to Courses repo:
        public async Task<RepoResponse<List<StudentReturnDto>>> LoadCourseStudents(Guid cId)
        {
            var students = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(ccs => ccs.Student)
                    .ThenInclude(s => s.Speciality)
                .Where(ccs => ccs.CourseId == cId)
                .Select(c => new StudentReturnDto()
                {
                    Id = c.Student.Id,
                    Name = c.Student.Name,
                    Details = c.Student.Details,
                    Email = c.Student.Email,
                    Gender = c.Student.Gender,
                    SpecialityId = c.Student.SpecialityId,
                    SpecialityName = c.Student.Speciality.Name
                })
                .ToListAsync();

            if (students == null)
            {
                return new RepoResponse<List<StudentReturnDto>>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<StudentReturnDto>>()
            {
                Content = students,
                IsSuccess = true,
                Message = _config["SuccessCodes:found"]
            };
        }
    
    }
}