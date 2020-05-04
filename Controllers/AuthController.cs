using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDMS.Data;
using SDMS.Models;
using SDMS.Models.Dtos;
using SDMS.Repos.Auth;
using SDMS.Utilities;

namespace SDMS.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepo _repo;
        private readonly SDMSContext _context; // TODO delete

        public AuthController(IAuthRepo repo, SDMSContext context)
        {
            this._repo = repo;
            this._context = context; // TODO delete
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        [Route("RegisterStudent")]
        public async Task<IActionResult> GetRegisterStudent(string error = "", string info = "")
        {
            var specs = await _context.Specialities // TODO Fetch from specialities repo
                .AsNoTracking()
                .ToListAsync();

            ViewBag.Specs = specs;
            ViewBag.Error = error;
            ViewBag.Info = info;
            return View("RegisterStudent");
        }

        [HttpPost]
        [Route("RegisterStudent")]
        public async Task<IActionResult> PostRegisterStudent(StudentRegisterDto student)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(GetRegisterStudent));
            }

            var result = await _repo.RegisterStudent(student);
            if (result.IsSuccess)
            {
                return RedirectToAction(
                    "GetRegisterStudent",
                    routeValues: new { info = result.Message }
                );
            }
            return RedirectToAction(
                nameof(GetRegisterStudent),
                routeValues: new { error = result.Message }
            );
        }

        [HttpGet]
        [Route("RegisterTeacher")]
        public async Task<IActionResult> GetRegisterTeacher(string error = "", string info = "")
        {
            var courses = await _context.Courses // TODO Fetch from courses repo
                .AsNoTracking()
                .Select(c => new TeacherCourseAddDto
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            ViewBag.Courses = courses;
            ViewBag.Error = error;
            ViewBag.Info = info;
            return View("RegisterTeacher");
        }

        [HttpPost]
        [Route("RegisterTeacher")]
        public async Task<IActionResult> PostRegisterTeacher(TeacherRegisterDto teacher,
            ICollection<Guid> courses)
        {
            teacher.CourseIds = courses;
            if (!ModelState.IsValid)
            {
                return RedirectToAction(
                    "GetRegisterTeacher",
                    routeValues: new { error = "Model State is not valid. " }
                );
            }

            var result = await _repo.RegisterTeacher(teacher);
            if (result.IsSuccess)
                return RedirectToAction(
                    "GetRegisterTeacher",
                    routeValues: new { info = result.Message }
                );

            return RedirectToAction(
                "GetRegisterTeacher",
                routeValues: new { error = result.Message }
            );
        }

        [HttpGet]
        [Route("LoginStudent")]
        public IActionResult GetLoginStudent(string error = "")
        {
            ViewBag.Error = error;
            return View("LoginStudent");
        }

        [HttpPost]
        [Route("LoginStudent")]
        public async Task<IActionResult> PostLoginStudent(StudentLoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(
                    actionName: "GetLoginStudent",
                    routeValues: new { error = "Invalid login credentials." }
                );
            }

            var result = await _repo.LoginStudent(loginDto);

            if (result.IsSuccess)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, result.Content.Id.ToString()),
                    new Claim(ClaimTypes.Name, result.Content.Name),
                    new Claim(ClaimTypes.Email, result.Content.Email),
                    new Claim(ClaimTypes.Role, "student")
                };

                var identity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("GetStudentProfile");
            }
            return RedirectToAction(
                "GetLoginStudent",
                routeValues: new { error = result.Message }
            );
        }

        [HttpGet]
        [Authorize(Roles = "student,teacher")]
        [Route("StudentProfile")]
        public async Task<IActionResult> GetStudentProfile()
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var studentViewModel = await _repo.GetStudent(idGuid);

            if (studentViewModel.IsSuccess)
                return View("StudentProfile", model: studentViewModel.Content);

            return RedirectToAction(
                "GetLoginStudent",
                routeValues: new { error = "Couldn't load student profile." }
            );
        }

        [HttpGet]
        [Route("LoginTeacher")]
        public IActionResult GetLoginTeacher(string error = "")
        {
            ViewBag.Error = error;
            return View("LoginTeacher");
        }

        [HttpPost]
        [Route("LoginTeacher")]
        public async Task<IActionResult> PostLoginTeacher(TeacherLoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(
                    actionName: "GetLoginTeacher",
                    routeValues: new { error = "Invalid login credentials." }
                );
            }

            var result = await _repo.LoginTeacher(loginDto);

            if (result.IsSuccess)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, result.Content.Id.ToString()),
                    new Claim(ClaimTypes.Name, result.Content.Name),
                    new Claim(ClaimTypes.Email, result.Content.Email),
                    new Claim(ClaimTypes.Role, "teacher")
                };

                var identity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("GetTeacherProfile");
            }
            return RedirectToAction(
                "GetLoginTeacher",
                routeValues: new { error = result.Message }
            );
        }

        [HttpGet]
        [Authorize(Roles = "teacher")]
        [Route("TeacherProfile")]
        public async Task<IActionResult> GetTeacherProfile()
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var response = await _repo.GetTeacher(idGuid);

            if (response.IsSuccess)
                return View("TeacherProfile", model: response.Content);

            return RedirectToAction(
                "LoginTeacher",
                routeValues: new { error = "Couldn't log in teacher" }
            );
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}