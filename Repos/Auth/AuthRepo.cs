using System.Threading.Tasks;
using SDMS.Models;
using SDMS.Models.Dtos;
using SDMS.Data;
using SDMS.Utilities;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Collections;
using System.Collections.Generic;

namespace SDMS.Repos.Auth
{
    public class AuthRepo : IAuthRepo
    {
        private readonly SDMSContext _context;
        private readonly IConfiguration _config;

        public AuthRepo(SDMSContext context, IConfiguration config)
        {
            this._context = context;
            this._config = config;
        }

        public async Task<RepoResponse<StudentReturnDto>> LoginStudent(StudentLoginDto loginCreds)
        {
            var student = await AuthenticateStudent(loginCreds);

            if (student == null)
            {
                var failResponse = new RepoResponse<StudentReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:login"]
                };
                return failResponse;
            }

            if (student.RegisterStatus != RegistrationStatus.Approved)
            {
                return new RepoResponse<StudentReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:reg_status"],
                    Content = student
                };
            }

            var token = GenerateToken(student.Id, student.Email, "student");

            var response = new RepoResponse<StudentReturnDto>()
            {
                IsSuccess = true,
                Content = student,
                //Message = token (token based auth)
                Message = _config["SuccessCodes:login"]
            };

            return response;
        }

        public async Task<RepoResponse<TeacherReturnDto>> LoginTeacher(TeacherLoginDto loginCreds)
        {
            var teacher = await AuthenticateTeacher(loginCreds);

            if (teacher == null)
            {
                var failResponse = new RepoResponse<TeacherReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:login"]
                };
                return failResponse;
            }

            if (teacher.RegisterStatus != RegistrationStatus.Approved)
            {
                return new RepoResponse<TeacherReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:reg_status"],
                    Content = teacher
                };
            }

            var token = GenerateToken(teacher.Id, teacher.Email, "teacher");

            var response = new RepoResponse<TeacherReturnDto>()
            {
                Content = teacher,
                IsSuccess = true,
                // Message = token (token based auth)
                Message = _config["SuccessCodes:login"]
            };

            return response;
        }

        public async Task<RepoResponse<StudentReturnDto>> RegisterStudent(StudentRegisterDto registerCreds)
        {
            // Check for existing student:
            var oldStudent = await _context.Students
                .FirstOrDefaultAsync(s => registerCreds.Email.ToLower() == s.Email.ToLower() ||
                    s.CardNumber.ToLower() == registerCreds.CardNumber.ToLower());
            if (oldStudent != null)
            {
                return new RepoResponse<StudentReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:record_exists"]
                };
            }

            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Details = registerCreds.Details,
                Email = registerCreds.Email,
                Gender = registerCreds.Gender,
                Name = registerCreds.Name,
                Password = Helper.ComputeHash(registerCreds.Password),
                Role = Role.Student,
                SpecialityId = registerCreds.SpecialityId,
                RegisterStatus = RegistrationStatus.Pending,
                CardNumber = registerCreds.CardNumber
            };

            await _context.Students.AddAsync(student);
            var contextResult = await _context.SaveChangesAsync();

            if (contextResult > 0)
            {
                var studentReturn = await _context.Students
                    .AsNoTracking()
                    .Include(s => s.Speciality)
                    .Select(s => new StudentReturnDto()
                    {
                        Id = s.Id,
                        Details = s.Details,
                        Email = s.Email,
                        Gender = s.Gender,
                        Name = s.Name,
                        SpecialityId = s.SpecialityId,
                        SpecialityName = s.Speciality.Name,
                        RegisterStatus = s.RegisterStatus
                    })
                    .FirstOrDefaultAsync(s => s.Id == student.Id);

                if (studentReturn != null)
                {
                    return new RepoResponse<StudentReturnDto>()
                    {
                        Content = studentReturn,
                        IsSuccess = true,
                        Message = _config["SuccessCodes:created"]
                    };
                }
            }

            return new RepoResponse<StudentReturnDto>()
            {
                IsSuccess = false,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public async Task<RepoResponse<TeacherReturnDto>> RegisterTeacher(TeacherRegisterDto registerCreds)
        {
            var oldTeacher = await _context.Teachers
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Email.ToLower() == registerCreds.Email.ToLower() ||
                    t.CardNumber.ToLower() == registerCreds.CardNumber.ToLower());

            if (oldTeacher != null)
            {
                return new RepoResponse<TeacherReturnDto>()
                {
                    IsSuccess = false,
                    Message = _config["ErrorCodes:record_exists"]
                };
            }

            var newTeacherId = Guid.NewGuid();
            var newTeacher = new Teacher()
            {
                Id = newTeacherId,
                Name = registerCreds.Name,
                CardNumber = registerCreds.CardNumber,
                CVPath = registerCreds.CVPath,
                Details = registerCreds.Details,
                Email = registerCreds.Email,
                Gender = registerCreds.Gender,
                Password = Helper.ComputeHash(registerCreds.Password),
                Role = Role.Teacher,
                RegisterStatus = RegistrationStatus.Pending
            };

            var teacherCourses = new List<TeacherCourse>();
            foreach (var courseGuid in registerCreds.CourseIds)
            {
                teacherCourses.Add(
                    new TeacherCourse()
                    {
                        CourseId = courseGuid,
                        TeacherId = newTeacherId
                    }
                );
            }

            await _context.Teachers.AddAsync(newTeacher);
            await _context.TeacherCourses.AddRangeAsync(teacherCourses);
            var dbResult = await _context.SaveChangesAsync();

            if (dbResult > 0)
            {
                var addedTeacher = await _context.Teachers
                    .AsNoTracking()
                    .Select(t => new TeacherReturnDto()
                    {
                        Id = t.Id,
                        CardNumber = t.CardNumber,
                        CVPath = t.CVPath,
                        Details = t.Details,
                        Email = t.Email,
                        Gender = t.Gender,
                        Name = t.Name,
                        RegisterStatus = t.RegisterStatus
                    })
                    .FirstOrDefaultAsync(t => t.Id == newTeacher.Id);

                if (addedTeacher != null)
                {
                    return new RepoResponse<TeacherReturnDto>()
                    {
                        Content = addedTeacher,
                        IsSuccess = true,
                        Message = _config["SuccessCodes:created"]
                    };
                }
            }

            return new RepoResponse<TeacherReturnDto>()
            {
                IsSuccess = false,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public Task<RepoResponse<bool>> DeleteStudent(StudentLoginDto creds)
        {
            throw new System.NotImplementedException();
        }

        public Task<RepoResponse<bool>> DeleteTeacher(TeacherLoginDto creds)
        {
            throw new System.NotImplementedException();
        }

        private async Task<TeacherReturnDto> AuthenticateTeacher(TeacherLoginDto loginCreds)
        {
            var password = Helper.ComputeHash(loginCreds.Password);
            var teachersWithEmail = _context.Teachers
                .AsNoTracking()
                .Where(t => t.Email.ToLower() == loginCreds.Email.ToLower());

            foreach (var teacher in teachersWithEmail)
            {
                if (Helper.Equals(teacher.Password, password))
                {
                    var courses = await _context.TeacherCourses
                        .AsNoTracking()
                        .Include(tc => tc.Teacher)
                        .Include(tc => tc.Course)
                        .Where(tc => tc.TeacherId == teacher.Id)
                        .Select(tc => new CourseReturnDto()
                        {
                            Id = tc.CourseId,
                            Name = tc.Course.Name,
                            AbsenceLimit = tc.Course.AbsenceLimit,
                            Credit = tc.Course.Credit,
                            SyllabusPath = tc.Course.SyllabusPath
                        })
                        .ToListAsync();

                    var returnData = new TeacherReturnDto()
                    {
                        Id = teacher.Id,
                        Name = teacher.Name,
                        Gender = teacher.Gender,
                        Email = teacher.Email,
                        Details = teacher.Details,
                        CVPath = teacher.CVPath,
                        Courses = courses,
                        RegisterStatus = teacher.RegisterStatus
                    };
                    return returnData;
                }
            }
            return null;
        }

        private async Task<StudentReturnDto> AuthenticateStudent(StudentLoginDto loginCreds)
        {
            var password = Helper.ComputeHash(loginCreds.Password);
            var studentsWithEmail = _context.Students
                .AsNoTracking()
                .Include(s => s.Speciality)
                .Where(t => t.Email.ToLower() == loginCreds.Email.ToLower());

            foreach (var student in studentsWithEmail)
            {
                if (Helper.Equals(student.Password, password))
                {

                    var currentCourses = await _context.CurrentCourseStudents
                        .AsNoTracking()
                        .Include(cs => cs.Course)
                        .Where(c => c.StudentId == student.Id)
                        .Select(cs => new CourseReturnDto()
                        {
                            Id = cs.Course.Id,
                            Name = cs.Course.Name,
                            AbsenceLimit = cs.Course.AbsenceLimit,
                            Credit = cs.Course.Credit,
                            SyllabusPath = cs.Course.SyllabusPath
                        }).ToListAsync();

                    var studentReturn = new StudentReturnDto()
                    {
                        Id = student.Id,
                        CurrentCourses = currentCourses,
                        Details = student.Details,
                        Email = student.Email,
                        Gender = student.Gender,
                        Name = student.Name,
                        SpecialityId = student.SpecialityId,
                        SpecialityName = student.Speciality.Name,
                        RegisterStatus = student.RegisterStatus
                    };

                    return studentReturn;
                }
            }
            return null;
        }

        private string GenerateToken(Guid id, string email, string role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, id.ToString()),
                new Claim("role", role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, email)
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }

        public async Task<RepoResponse<Admin>> RegisterAdmin(string email, string password)
        {
            var oldAdmin = _context.Admins
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Email.ToLower() == email.ToLower());
            if (oldAdmin != null)
            {
                return new RepoResponse<Admin>()
                {
                    IsSuccess = false,
                    Content = null,
                    Message = _config["ErrorCodes:record_exists"]
                };
            }

            var admin = new Admin()
            {
                Id = Guid.NewGuid(),
                Email = email,
                Password = Helper.ComputeHash(password)
            };
            await _context.Admins.AddAsync(admin);
            var dbResult = await _context.SaveChangesAsync();
            if (dbResult > 0)
            {
                var loginResult = await LoginAdmin(admin.Email, password);
                if (loginResult.IsSuccess)
                {
                    return new RepoResponse<Admin>()
                    {
                        Content = admin,
                        IsSuccess = true,
                        Message = loginResult.Message
                    };
                }
                var status = loginResult.Content.RegistrtationStatus;
                var strStatus = status == RegistrationStatus.Pending ? "Pending" : "Cancelled";
                return new RepoResponse<Admin>()
                {
                    Content = loginResult.Content,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:reg_status"]
                };
            }
            return new RepoResponse<Admin>()
            {
                Content = null,
                IsSuccess = false,
                Message = _config["ErrorCodes:db_error"]
            };
        }

        public async Task<RepoResponse<Admin>> LoginAdmin(string email, string password)
        {
            var admin = await AuthenticateAdmin(email, password);
            if (admin == null)
            {
                return new RepoResponse<Admin>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:login"]
                };
            }

            return new RepoResponse<Admin>()
            {
                Content = admin,
                IsSuccess = true,
                //Message = GenerateToken(admin.Id, admin.Email, "admin")
                Message = _config["SuccessCodes:login"]
            };
        }

        private async Task<Admin> AuthenticateAdmin(string email, string password)
        {
            var admins = await _context.Admins
                .AsNoTracking()
                .Where(a => a.Email.ToLower() == email.ToLower())
                .ToListAsync();

            if (admins == null)
            {
                return null;
            }

            foreach (var admin in admins)
            {
                var loginPass = Helper.ComputeHash(password);
                if (Helper.Equals(admin.Password, loginPass))
                {
                    return admin;
                }
            }
            return null;
        }

        public async Task<RepoResponse<StudentReturnDto>> GetStudent(Guid id)
        {
            var student = await _context.Students
                .AsNoTracking()
                .Include(s => s.Speciality)
                .Include(s => s.CurrentCourseStudents)
                    .ThenInclude(ccs => ccs.Course)
                .Include(s => s.CurrentCourseStudents)
                    .ThenInclude(ccs => ccs.CourseTeacher)
                .Select(s => new StudentReturnDto()
                {
                    Id = s.Id,
                    Details = s.Details,
                    Email = s.Email,
                    Gender = s.Gender,
                    Name = s.Name,
                    RegisterStatus = s.RegisterStatus,
                    SpecialityId = s.SpecialityId,
                    SpecialityName = s.Speciality.Name,
                    CurrentCourses = s.CurrentCourseStudents
                        .Where(ccs => ccs.StudentId == s.Id)
                        .Select(ccs => new CourseReturnDto()
                        {
                            Id = ccs.Course.Id,
                            AbsenceLimit = ccs.Course.AbsenceLimit,
                            Credit = ccs.Course.Credit,
                            Name = ccs.Course.Name,
                            SyllabusPath = ccs.Course.SyllabusPath,
                            Teacher = new TeacherReturnDto()
                            {
                                Id = ccs.CourseTeacher.Id,
                                CardNumber = ccs.CourseTeacher.CardNumber,
                                CVPath = ccs.CourseTeacher.CVPath,
                                Details = ccs.CourseTeacher.Details,
                                Email = ccs.CourseTeacher.Email,
                                Gender = ccs.CourseTeacher.Gender,
                                Name = ccs.CourseTeacher.Name,
                                RegisterStatus = ccs.CourseTeacher.RegisterStatus
                            }
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync(s => s.Id == id);

            if (student == null)
            {
                return new RepoResponse<StudentReturnDto>()
                {
                    Content = null,
                    IsSuccess = false,
                    Message = _config["ErrorCodes:not_found"]
                };
            }

            return new RepoResponse<StudentReturnDto>()
            {
                Content = student,
                IsSuccess = true,
                Message = _config["SuccessCodes:found"]
            };
        }

        public async Task<RepoResponse<TeacherReturnDto>> GetTeacher(Guid id)
        {
            var teacher = await _context.Teachers
                .AsNoTracking()
                .Include(t => t.TeacherCourses)
                    .ThenInclude(tc => tc.Course)
                .Select(t => new TeacherReturnDto()
                {
                    Id = t.Id,
                    CardNumber = t.CardNumber,
                    CVPath = t.CVPath,
                    Details = t.Details,
                    Email = t.Email,
                    Gender = t.Gender,
                    Name = t.Name,
                    RegisterStatus = t.RegisterStatus,
                    Courses = t.TeacherCourses
                        .Select(tc => new CourseReturnDto()
                        {
                            Id = tc.Course.Id,
                            Name = tc.Course.Name,
                            Credit = tc.Course.Credit,
                            AbsenceLimit = tc.Course.AbsenceLimit,
                            SyllabusPath = tc.Course.SyllabusPath
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync(t => t.Id == id);

            if (teacher != null)
            {
                return new RepoResponse<TeacherReturnDto>()
                {
                    Content = teacher,
                    IsSuccess = true,
                    Message = _config["SuccessCodes:found"]
                };
            }

            return new RepoResponse<TeacherReturnDto>()
            {
                Content = null,
                IsSuccess = false,
                Message = _config["ErrorCodes:db_error"]
            };
        }
    }
}