using System;
using System.Threading.Tasks;
using SDMS.Models;
using SDMS.Models.Dtos;
using SDMS.Utilities;

namespace SDMS.Repos.Auth
{
    public interface IAuthRepo
    {
        Task<RepoResponse<Admin>> RegisterAdmin(string email, string password);
        Task<RepoResponse<Admin>> LoginAdmin(string email, string password);
        Task<RepoResponse<StudentReturnDto>> RegisterStudent(StudentRegisterDto registerCreds);
        Task<RepoResponse<StudentReturnDto>> LoginStudent(StudentLoginDto loginCreds);
        Task<RepoResponse<TeacherReturnDto>> RegisterTeacher(TeacherRegisterDto registerCreds);
        Task<RepoResponse<TeacherReturnDto>> LoginTeacher(TeacherLoginDto loginCreds);
        Task<RepoResponse<StudentReturnDto>> GetStudent(Guid id);
        Task<RepoResponse<TeacherReturnDto>> GetTeacher(Guid id);
    }
}