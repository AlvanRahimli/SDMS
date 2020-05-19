using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SDMS.Data;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Courses
{
    public class CoursesRepo : ICoursesRepo
    {
        private readonly SDMSContext _context;
        private readonly IConfiguration _config;

        public CoursesRepo(SDMSContext _context, IConfiguration config)
        {
            this._context = _context;
            this._config = config;
        }

        public async Task<RepoResponse<CourseReturnDto>> GetCourse(Guid cId)
        {
            var course = await _context.Courses
                .AsNoTracking()
                .Select(c => new CourseReturnDto()
                {
                    Id = c.Id,
                    AbsenceLimit = c.AbsenceLimit,
                    Credit = c.Credit,
                    Name = c.Name,
                    SyllabusPath = c.SyllabusPath
                })
                .FirstOrDefaultAsync(c => c.Id == cId);

            if (course == null)
            {
                return new RepoResponse<CourseReturnDto>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            var teachers = await _context.TeacherCourses
                .AsNoTracking()
                .Include(tc => tc.Teacher)
                .Where(tc => tc.CourseId == course.Id)
                .Select(tc => new TeacherReturnDto()
                {
                    Id = tc.Teacher.Id,
                    CVPath = tc.Teacher.CVPath,
                    Details = tc.Teacher.Details,
                    Email = tc.Teacher.Email,
                    Name = tc.Teacher.Name,
                    Gender = tc.Teacher.Gender
                })
                .ToListAsync();
            var prerequisites = await _context.Courses
                .AsNoTracking()
                .Where(c => c.RequiredById == cId)
                .Select(c => new CourseReturnDto()
                {
                    Id = c.Id,
                    AbsenceLimit = c.AbsenceLimit,
                    Credit = c.Credit,
                    Name = c.Name,
                    SyllabusPath = c.SyllabusPath
                })
                .ToListAsync();

            course.Teachers = teachers;
            course.Prerequisites = prerequisites;

            return new RepoResponse<CourseReturnDto>()
            {
                Content = course,
                IsSuccess = true,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<List<CourseReturnDto>>> GetCourses()
        {
            var courses = await _context.Courses
                .AsNoTracking()
                .Select(c => new CourseReturnDto()
                {
                    Id = c.Id,
                    AbsenceLimit = c.AbsenceLimit,
                    Credit = c.Credit,
                    Name = c.Name,
                    SyllabusPath = c.SyllabusPath
                })
                .ToListAsync();

            if (courses == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<CourseReturnDto>>()
            {
                Content = courses,
                IsSuccess = false,
                Message = _config["ErrorCodes:found"]
            };
        }

        public async Task<RepoResponse<List<TeacherCourseAddDto>>> GetCoursesBrief()
        {
            var courses = await _context.Courses
                .AsNoTracking()
                .Select(c => new TeacherCourseAddDto()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            if (courses == null)
            {
                return new RepoResponse<List<TeacherCourseAddDto>>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<TeacherCourseAddDto>>()
            {
                Content = courses,
                IsSuccess = true,
                Message = _config["ErrorCodes:found"]
            };
        }

        public async Task<RepoResponse<List<TeacherCourseAddDto>>> GetCoursesBrief(Guid tId)
        {
            var courses = await _context.TeacherCourses
                .AsNoTracking()
                .Include(tc => tc.Course)
                .Where(tc => tc.TeacherId == tId)
                .Select(c => new TeacherCourseAddDto()
                {
                    Id = c.Course.Id,
                    Name = c.Course.Name
                })
                .ToListAsync();

            if (courses == null)
            {
                return new RepoResponse<List<TeacherCourseAddDto>>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<TeacherCourseAddDto>>()
            {
                Content = courses,
                IsSuccess = true,
                Message = _config["ErrorCodes:found"]
            };
        }

        public async Task<RepoResponse<List<StudentReturnDto>>> GetStudentList(Guid cId)
        {
            var students = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(ccs => ccs.Student)
                    .ThenInclude(s => s.Speciality)
                .Where(ccs => ccs.CourseId == cId)
                .Select(ccs => new StudentReturnDto()
                {
                    Id = ccs.Student.Id,
                    Details = ccs.Student.Details,
                    Email = ccs.Student.Email,
                    Gender = ccs.Student.Gender,
                    Name = ccs.Student.Name,
                    RegisterStatus = ccs.Student.RegisterStatus,
                    SpecialityId = ccs.Student.SpecialityId,
                    SpecialityName = ccs.Student.Speciality.Name,
                })
                .OrderBy(s => s.Name)
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

        public async Task<RepoResponse<List<StudentReturnDto>>> GetStudentListWTeacher(Guid cId, Guid tId)
        {
            var students = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(ccs => ccs.Student)
                    .ThenInclude(s => s.Speciality)
                .Where(ccs => ccs.CourseId == cId && ccs.CourseTeacherId == tId)
                .Select(ccs => new StudentReturnDto()
                {
                    Id = ccs.Student.Id,
                    Details = ccs.Student.Details,
                    Email = ccs.Student.Email,
                    Gender = ccs.Student.Gender,
                    Name = ccs.Student.Name,
                    RegisterStatus = ccs.Student.RegisterStatus,
                    SpecialityId = ccs.Student.SpecialityId,
                    SpecialityName = ccs.Student.Speciality.Name,
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