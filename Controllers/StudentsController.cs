using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SDMS.Models.Dtos;
using SDMS.Repos.Students;

namespace SDMS.Controllers
{
    [Controller]
    [Route("[controller]")]
    [Authorize(Roles = "student")]
    public class StudentsController : Controller
    {
        private readonly IStudentsRepo _repo;
        private readonly IConfiguration _config;

        public StudentsController(IStudentsRepo repo, IConfiguration config)
        {
            this._repo = repo;
            this._config = config;
        }

        [HttpPost]
        [Route("Choose")]
        public async Task<IActionResult> SelectCourses(List<CourseNameIdDto> courses)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(
                    "GetCoursesToChoose",
                    routeValues: new { error = _config["ErrorCodes:model_state"] }
                );
            }

            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);
            var repoResponse = await _repo.ChooseCourses(idGuid, courses);

            if (!repoResponse.IsSuccess)
            {
                return RedirectToAction(
                    "GetCoursesToChoose",
                    routeValues: new { error = repoResponse.Message }
                );
            }

            return RedirectToAction(
                actionName: "GetStudentProfile",
                controllerName: "Auth"
            );
        }

        [HttpGet]
        [Route("Choose")]
        public async Task<IActionResult> GetCoursesToChoose(string error = "")
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);
            var repoResponse = await _repo.LoadCoursesToChoose(idGuid);

            if (!repoResponse.IsSuccess)
            {
                ViewBag.Error = repoResponse.Message;
                return View("Choose");
            }

            ViewBag.Courses = repoResponse.Content;
            ViewBag.Error = error;
            return View("Choose");
        }

        [HttpGet]
        [Route("LoadTaken")]
        public async Task<IActionResult> LoadTaken(string error = "")
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);
            var repoResponse = await _repo.LoadTakenCourses(idGuid);

            if (!repoResponse.IsSuccess)
            {
                ViewBag.Error = repoResponse.Message;
                return View("TakenCourses");
            }

            ViewBag.Error = error;
            return View(
                "TakenCourses",
                model: repoResponse.Content
            );
        }

        [HttpGet]
        [Route("Scores")]
        public async Task<IActionResult> LoadScores(string error = "")
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var result = await _repo.LoadCurrentCourses(idGuid);

            if (result.IsSuccess)
            {
                ViewBag.Courses = result.Content;
                ViewData["For"] = "scores";
                return View("SelectDate");
            }

            ViewBag.Error = error;
            return View("Oops");
        }

        [HttpPost]
        [Route("Scores")]
        public async Task<IActionResult> LoadScores(DateModel dm)
        {
            if (dm.ForId == Guid.Empty)
            {
                return RedirectToAction(
                    actionName: "LoadScores",
                    controllerName: "Students"
                );
            }
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var result = await _repo.LoadScores(idGuid, dm.ForId, dm.StartDate, dm.FinishDate);

            if (result.IsSuccess)
            {
                ViewBag.Scores = result.Content;
                ViewBag.Message = result.Message;
                return View("Scores");
            }

            return RedirectToAction(
                actionName: "LoadScores",
                controllerName: "Students",
                routeValues: new { error = result.Message }
            );
        }

        [HttpGet]
        [Route("Attendances")]
        public async Task<IActionResult> LoadAttendances(string error = "")
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var result = await _repo.LoadCurrentCourses(idGuid);

            if (result.IsSuccess)
            {
                ViewBag.Courses = result.Content;
                ViewData["For"] = "attendances";
                return View("SelectDate");
            }

            ViewBag.Error = error;
            return View("Oops");
        }

        [HttpPost]
        [Route("Attendances")]
        public async Task<IActionResult> LoadAttendances(DateModel dm)
        {
            if (dm.ForId == Guid.Empty)
            {
                return RedirectToAction(
                    actionName: "LoadAttendances",
                    controllerName: "Students"
                );
            }
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var result = await _repo.LoadAttendances(idGuid, dm.ForId, dm.StartDate, dm.FinishDate);

            if (result.IsSuccess)
            {
                ViewBag.Attendances = result.Content;
                ViewBag.Message = result.Message;
                return View("Attendances");
            }

            return RedirectToAction(
                actionName: "LoadAttendances",
                controllerName: "Students",
                routeValues: new { error = result.Message }
            );
        }
    
        [HttpGet]
        [Route("Student")]
        [AllowAnonymous]
        public async Task<IActionResult> Student(Guid sId)
        {
            if (sId == Guid.Empty)
                return View("Oops");
            
            var result = await _repo.GetStudent(sId);

            if (result.IsSuccess)
            {
                return View("Student", result.Content);
            }

            return View("Oops");
        }
    }
}
