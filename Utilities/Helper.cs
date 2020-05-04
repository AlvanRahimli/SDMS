using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SDMS.Models;

namespace SDMS.Utilities
{
    public static class Helper
    {
        public static byte[] ComputeHash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] passHash = sha256Hash
                    .ComputeHash(Encoding.UTF8.GetBytes(password));
                return passHash;
            }
        }

        public static bool Equals(byte[] pass, byte[] input)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] != input[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetCurrentUserGuid(HttpContext httpContext)
        {
            var identity = httpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claims = identity.Claims.ToList();
            return claims[0].Value;
        }

        public static void Seed(this ModelBuilder builder)
        {
            var calcI_Id = Guid.NewGuid();
            var calcII_Id = Guid.NewGuid();
            var prob_Id = Guid.NewGuid();
            var consep_Id = Guid.NewGuid();
            var introProg_Id = Guid.NewGuid();
            var physI_Id = Guid.NewGuid();
            var physII_Id = Guid.NewGuid();
            var systemEngId = Guid.NewGuid();
            var infotechId = Guid.NewGuid();
            var alvanId = Guid.NewGuid();
            var samirId = Guid.NewGuid();
            var anarId = Guid.NewGuid();
            var konulId = Guid.NewGuid();
            var ulviyyeId = Guid.NewGuid();
            var ceyhunId = Guid.NewGuid();
            var eleddinId = Guid.NewGuid();

            builder.Entity<Course>().HasData(
                new Course()
                {
                    Id = calcI_Id,
                    AbsenceLimit = 11,
                    Credit = 6,
                    Name = "Calculus I",
                    SyllabusPath = "N/A",
                    RequiredById = calcII_Id
                },
                new Course()
                {
                    Id = calcII_Id,
                    Name = "Calculus II",
                    AbsenceLimit = 11,
                    Credit = 6,
                    SyllabusPath = "N/A"
                },
                new Course()
                {
                    Id = prob_Id,
                    Name = "Probability and Statistics",
                    AbsenceLimit = 6,
                    Credit = 5,
                    SyllabusPath = "N/A"
                },
                new Course()
                {
                    Id = consep_Id,
                    Name = "System Engineering Conseption",
                    AbsenceLimit = 11,
                    Credit = 5,
                    SyllabusPath = "N/A"
                },
                new Course()
                {
                    Id = introProg_Id,
                    Name = "Introduction to Programming",
                    AbsenceLimit = 6,
                    Credit = 6,
                    SyllabusPath = "N/A"
                },
                new Course()
                {
                    Id = physI_Id,
                    Name = "Physics I",
                    AbsenceLimit = 13,
                    Credit = 4,
                    SyllabusPath = "N/A",
                    RequiredById = physII_Id
                },
                new Course()
                {
                    Id = physII_Id,
                    Name = "Physics II",
                    AbsenceLimit = 13,
                    Credit = 4,
                    SyllabusPath = "N/A"
                }
            );
            builder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    Id = systemEngId,
                    Name = "System Engineering",
                    StartDate = DateTime.Now
                },
                new Speciality()
                {
                    Id = infotechId,
                    Name = "Information Technologies",
                    StartDate = new DateTime(2020, 9, 16)
                }
            );
            builder.Entity<Student>().HasData(
                new Student()
                {
                    Id = alvanId,
                    Name = "Alvan Rahimli",
                    Email = "alvan@sdms.az",
                    CardNumber = "ALVA001",
                    Details = "BA Programs",
                    Gender = Gender.Male,
                    Password = ComputeHash("alvan12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Student,
                    SpecialityId = systemEngId
                },
                new Student()
                {
                    Id = samirId,
                    Name = "Samir Hasanov",
                    Email = "samir@sdms.az",
                    CardNumber = "SAMI001",
                    Details = "BA Programs",
                    Gender = Gender.Male,
                    Password = ComputeHash("samir12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Student,
                    SpecialityId = systemEngId
                }
            );
            builder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    Id = anarId,
                    Name = "Anar Kazimov",
                    CardNumber = "ANAR001",
                    CVPath = "N/A",
                    Details = "since 2017 teaching here. Test data LOL",
                    Email = "anar@sdms.az",
                    Gender = Gender.Male,
                    Password = ComputeHash("anar12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Teacher
                },
                new Teacher()
                {
                    Id = konulId,
                    Name = "Konul Jabbarova",
                    CardNumber = "KONU001",
                    CVPath = "N/A",
                    Details = "Cuuute teacher. doesn't know eng.",
                    Email = "konul@sdms.az",
                    Gender = Gender.Female,
                    Password = ComputeHash("konul12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Teacher
                },
                new Teacher()
                {
                    Id = ulviyyeId,
                    Name = "Ulviyye Memmedova",
                    CardNumber = "ULVI001",
                    CVPath = "N/A",
                    Details = "Meeh, not bad",
                    Email = "ulviyye@sdms.az",
                    Gender = Gender.Female,
                    Password = ComputeHash("ulviyye12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Teacher
                },
                new Teacher()
                {
                    Id = ceyhunId,
                    Name = "Ceyhun Naziyev",
                    CardNumber = "CEYH001",
                    CVPath = "N/A",
                    Details = "Veery Cuuute teacher. doesn't know eng.",
                    Email = "ceyhun@sdms.az",
                    Gender = Gender.Male,
                    Password = ComputeHash("ceyhun12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Teacher
                },
                new Teacher()
                {
                    Id = eleddinId,
                    Name = "Eleddin Memmedli",
                    CardNumber = "ELED001",
                    CVPath = "N/A",
                    Details = "Reis.",
                    Email = "eleddin@sdms.az",
                    Gender = Gender.Male,
                    Password = ComputeHash("eleddin12345"),
                    RegisterStatus = RegistrationStatus.Approved,
                    Role = Role.Teacher
                }
            );
            builder.Entity<Admin>().HasData(
                new Admin()
                {
                    Id = Guid.NewGuid(),
                    Password = ComputeHash("admin1-12345"),
                    Email = "admin1@sdms.az",
                    RegistrtationStatus = RegistrationStatus.Approved
                }
            );
            builder.Entity<Absence>().HasData(
                new Absence()
                {
                    Id = Guid.NewGuid(),
                    CourseId = calcI_Id,
                    StudentId = alvanId,
                    DateTime = DateTime.Now.AddMonths(10)
                },
                new Absence()
                {
                    Id = Guid.NewGuid(),
                    CourseId = calcI_Id,
                    StudentId = alvanId,
                    DateTime = DateTime.Now.AddMonths(10)
                },
                new Absence()
                {
                    Id = Guid.NewGuid(),
                    CourseId = calcII_Id,
                    StudentId = samirId,
                    DateTime = DateTime.Now.AddMonths(10).AddDays(15)
                }
            );
            builder.Entity<Score>().HasData(
                new Score()
                {
                    Id = Guid.NewGuid(),
                    StudentId = alvanId,
                    CourseId = calcI_Id,
                    Date = DateTime.Now.AddMonths(-3),
                    ScoreOver100 = 93
                },
                new Score()
                {
                    Id = Guid.NewGuid(),
                    StudentId = samirId,
                    CourseId = calcI_Id,
                    Date = DateTime.Now.AddMonths(-2),
                    ScoreOver100 = 85
                },
                new Score()
                {
                    Id = Guid.NewGuid(),
                    StudentId = samirId,
                    CourseId = calcII_Id,
                    Date = DateTime.Now.AddMonths(-3).AddDays(12),
                    ScoreOver100 = 100
                }
            );
            builder.Entity<TakenCourseStudent>().HasData(
                new TakenCourseStudent()
                {
                    CourseId = calcI_Id,
                    StudentId = alvanId,
                    CourseTeacherId = anarId
                },
                new TakenCourseStudent()
                {
                    CourseId = prob_Id,
                    StudentId = alvanId,
                    CourseTeacherId = konulId
                },
                new TakenCourseStudent()
                {
                    CourseId = calcI_Id,
                    StudentId = samirId,
                    CourseTeacherId = anarId
                },
                new TakenCourseStudent()
                {
                    CourseId = calcII_Id,
                    StudentId = samirId,
                    CourseTeacherId = anarId
                }
            );
            builder.Entity<CurrentCourseStudent>().HasData(
                new CurrentCourseStudent()
                {
                    StudentId = alvanId,
                    CourseId = calcII_Id,
                    CourseTeacherId = anarId
                }
            );
            builder.Entity<TeacherCourse>().HasData(
                new TeacherCourse()
                {
                    CourseId = calcI_Id,
                    TeacherId = anarId
                },
                new TeacherCourse()
                {
                    CourseId = calcII_Id,
                    TeacherId = anarId
                },
                new TeacherCourse()
                {
                    CourseId = prob_Id,
                    TeacherId = konulId
                },
                new TeacherCourse()
                {
                    CourseId = introProg_Id,
                    TeacherId = ulviyyeId
                },
                new TeacherCourse()
                {
                    CourseId = physI_Id,
                    TeacherId = ceyhunId
                },
                new TeacherCourse()
                {
                    CourseId = physII_Id,
                    TeacherId = ceyhunId
                },
                new TeacherCourse()
                {
                    CourseId = calcI_Id,
                    TeacherId = eleddinId
                },
                new TeacherCourse()
                {
                    CourseId = calcII_Id,
                    TeacherId = eleddinId
                }
            );
            builder.Entity<CourseSpeciality>().HasData(
                new CourseSpeciality()
                {
                    CourseId = calcI_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = calcII_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = prob_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = prob_Id,
                    SpecialityId = infotechId
                },
                new CourseSpeciality()
                {
                    CourseId = introProg_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = physI_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = physII_Id,
                    SpecialityId = systemEngId
                },
                new CourseSpeciality()
                {
                    CourseId = physI_Id,
                    SpecialityId = infotechId
                },
                new CourseSpeciality()
                {
                    CourseId = physII_Id,
                    SpecialityId = infotechId
                }
            );
        }
    }
}