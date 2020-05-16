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
using Microsoft.AspNetCore.Mvc.Razor;

namespace SDMS.Repos.Students
{
    public class StudentsRepo : IStudentsRepo
    {
        private readonly SDMSContext _context;
        private readonly IConfiguration _config;

        public StudentsRepo(SDMSContext context, IConfiguration config)
        {
            this._context = context;
            this._config = config;
        }

        public async Task<RepoResponse<List<CourseNameIdDto>>> ChooseCourses(Guid studentId,
            List<CourseNameIdDto> courseIds)
        {
            // Delete unselected courses.
            courseIds = courseIds
                .Where(c => c.Id != Guid.Empty)
                .ToList();
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == studentId);
            var wantedCourses = new List<Course>();
            foreach (var want in courseIds)
            {
                var c = await _context.Courses
                    .AsNoTracking()
                    .Include(co => co.Prerequisites)
                    .FirstOrDefaultAsync(co => co.Id == want.Id);
                wantedCourses.Add(c);
            }
            var takenCourses = await _context.TakenCourseStudents
                .AsNoTracking()
                .Include(cs => cs.Course)
                .Where(cs => cs.StudentId == studentId)
                .ToListAsync();

            // Find courses that unavaliable to choose because 
            // of prerequisites.
            var unavaliableCourses = new List<CourseNameIdDto>();
            foreach (var wantedCourse in wantedCourses)
            {
                if (wantedCourse.Prerequisites.Count == 0)
                    continue;

                bool isAvaliable = false;
                foreach (var requisite in wantedCourse.Prerequisites)
                {
                    if (takenCourses.Any(tc => tc.CourseId == requisite.Id))
                    {
                        isAvaliable = true;
                    }
                    else
                    {
                        isAvaliable = false;
                    }
                }
                if (!isAvaliable)
                {
                    unavaliableCourses.Add(
                        new CourseNameIdDto()
                        {
                            Id = wantedCourse.Id,
                            CourseName = wantedCourse.Name
                        }
                    );
                }
            }

            // If you fail:
            if (unavaliableCourses.Count != 0)
            {
                return new RepoResponse<List<CourseNameIdDto>>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:unable_to_choose"],
                    Content = unavaliableCourses
                };
            }

            // If there is no unavaliable courses:
            var currentCourseStudents = courseIds
                .Select(wc => new CurrentCourseStudent()
                {
                    CourseId = wc.Id,
                    StudentId = student.Id,
                    CourseTeacherId = wc.TeacherId
                })
                .ToList();

            await _context.CurrentCourseStudents
                .AddRangeAsync(currentCourseStudents);
            var dbResult = await _context.SaveChangesAsync();

            if (dbResult > 0)
            {
                return new RepoResponse<List<CourseNameIdDto>>()
                {
                    IsSuccess = true,
                    Content = null,
                    Message = _config["SuccessCodes:choice"]
                };
            }
            return new RepoResponse<List<CourseNameIdDto>>()
            {
                IsSuccess = false,
                Content = null,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public async Task<RepoResponse<List<CourseReturnDto>>> LoadCoursesToChoose(Guid studentId)
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.Id == studentId);

            if (student == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            var courses = await _context.CourseSpecialities
                .AsNoTracking()
                .Include(cs => cs.Speciality)
                .Include(cs => cs.Course)
                    .ThenInclude(c => c.Prerequisites)
                .Where(cs => cs.SpecialityId == student.SpecialityId)
                .Select(cs => new CourseReturnDto()
                {
                    Id = cs.Course.Id,
                    AbsenceLimit = cs.Course.AbsenceLimit,
                    Credit = cs.Course.Credit,
                    Name = cs.Course.Name,
                    Prerequisites = cs.Course.Prerequisites
                        .Select(c => new CourseReturnDto()
                        {
                            Id = c.Id,
                            AbsenceLimit = c.AbsenceLimit,
                            Name = c.Name,
                            Credit = c.Credit,
                            SyllabusPath = c.SyllabusPath
                        }).ToList(),
                    SyllabusPath = cs.Course.SyllabusPath
                })
                .ToListAsync();

            var takenCourses = await _context.TakenCourseStudents
                .AsNoTracking()
                .Include(cs => cs.Course)
                .Where(cs => cs.StudentId == studentId)
                .ToListAsync();
            var currentCourses = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(cs => cs.Course)
                .Where(cs => cs.StudentId == studentId)
                .ToListAsync();


            for (int i = 0; i < courses.Count; i++)
            {
                bool isTaken = takenCourses.Any(tc => tc.CourseId == courses[i].Id);
                bool isCurrent = currentCourses.Any(tc => tc.CourseId == courses[i].Id);
                if (isTaken || isCurrent)
                {
                    courses.Remove(courses[i]);
                }
            }

            foreach (var course in courses)
            {
                var teachers = await _context.TeacherCourses
                    .AsNoTracking()
                    .Include(tc => tc.Teacher)
                    .Where(tc => tc.CourseId == course.Id)
                    .Select(tc => new TeacherReturnDto()
                    {
                        Id = tc.Teacher.Id,
                        CardNumber = tc.Teacher.CardNumber,
                        CVPath = tc.Teacher.CVPath,
                        Details = tc.Teacher.Details,
                        Email = tc.Teacher.Email,
                        Gender = tc.Teacher.Gender,
                        Name = tc.Teacher.Name
                    })
                    .ToListAsync();
                course.Teachers = teachers;
            }

            if (courses == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:no_course_for_spec"]
                };
            }

            return new RepoResponse<List<CourseReturnDto>>()
            {
                IsSuccess = true,
                Content = courses,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<List<CourseReturnDto>>> LoadTakenCourses(Guid studentId)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            var courses = await _context.TakenCourseStudents
                .AsNoTracking()
                .Include(x => x.Course)
                .Include(x => x.CourseTeacher)
                .Where(c => c.StudentId == studentId)
                .Select(x => new CourseReturnDto()
                {
                    Id = x.Course.Id,
                    Name = x.Course.Name,
                    AbsenceLimit = x.Course.AbsenceLimit,
                    Credit = x.Course.Credit,
                    SyllabusPath = x.Course.SyllabusPath,
                    Teacher = new TeacherReturnDto()
                    {
                        Id = x.CourseTeacher.Id,
                        CardNumber = x.CourseTeacher.CardNumber,
                        CVPath = x.CourseTeacher.CVPath,
                        Details = x.CourseTeacher.Details,
                        Email = x.CourseTeacher.Email,
                        Gender = x.CourseTeacher.Gender,
                        Name = x.CourseTeacher.Name,
                        RegisterStatus = x.CourseTeacher.RegisterStatus
                    }
                }).ToListAsync();

            if (courses == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<CourseReturnDto>>()
            {
                IsSuccess = true,
                Content = courses,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<List<Score>>> LoadScores(Guid studentId, Guid courseId,
            DateTime startDate, DateTime finishDate)
        {
            var student = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Where(ccs => ccs.CourseId == courseId && ccs.StudentId == studentId)
                .ToListAsync();
            if (student == null)
            {
                return new RepoResponse<List<Score>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:student_course"]
                };
            }

            var scores = await _context.Scores
                .AsNoTracking()
                .Include(s => s.Course)
                .Where(s => DateTime.Compare(s.Date, startDate) > 0
                            && DateTime.Compare(s.Date, finishDate) < 0
                            && s.StudentId == studentId
                            && s.CourseId == courseId)
                .ToListAsync();
            if (scores == null)
            {
                return new RepoResponse<List<Score>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<Score>>()
            {
                IsSuccess = true,
                Content = scores,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<List<Absence>>> LoadAttendances(Guid studentId, Guid courseId,
            DateTime startDate, DateTime finishDate)
        {
            var student = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Where(ccs => ccs.CourseId == courseId && ccs.StudentId == studentId)
                .ToListAsync();
            if (student == null)
            {
                return new RepoResponse<List<Absence>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:student_course"]
                };
            }

            var absences = await _context.Absences
                .AsNoTracking()
                .Where(s => DateTime.Compare(s.DateTime, startDate) > 0
                            && DateTime.Compare(s.DateTime, finishDate) < 0
                            && s.StudentId == studentId
                            && s.CourseId == courseId)
                .ToListAsync();
            if (absences == null)
            {
                return new RepoResponse<List<Absence>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<Absence>>()
            {
                IsSuccess = true,
                Content = absences,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<List<CourseReturnDto>>> LoadCurrentCourses(Guid studentId)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            var courses = await _context.CurrentCourseStudents
                .AsNoTracking()
                .Include(x => x.Course)
                .Include(x => x.CourseTeacher)
                .Where(c => c.StudentId == studentId)
                .Select(x => new CourseReturnDto()
                {
                    Id = x.Course.Id,
                    Name = x.Course.Name,
                    AbsenceLimit = x.Course.AbsenceLimit,
                    Credit = x.Course.Credit,
                    SyllabusPath = x.Course.SyllabusPath,
                    Teacher = new TeacherReturnDto()
                    {
                        Id = x.CourseTeacher.Id,
                        CardNumber = x.CourseTeacher.CardNumber,
                        CVPath = x.CourseTeacher.CVPath,
                        Details = x.CourseTeacher.Details,
                        Email = x.CourseTeacher.Email,
                        Gender = x.CourseTeacher.Gender,
                        Name = x.CourseTeacher.Name,
                        RegisterStatus = x.CourseTeacher.RegisterStatus
                    }
                }).ToListAsync();

            if (courses == null)
            {
                return new RepoResponse<List<CourseReturnDto>>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<List<CourseReturnDto>>()
            {
                IsSuccess = true,
                Content = courses,
                Message = _config["SuccessCodes:found"]
            };
        }
    }
}