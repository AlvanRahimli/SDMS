using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SDMS.Models.Dtos;
using SDMS.Repos.Students;

namespace SDMS.Controllers
{
    [Controller]
    [Route("[controller]")]
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
        [Route("choose")]
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
        [Route("choose")]
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
        [Route("LoadScores")]
        public IActionResult LoadScores(string error = "")
        {
            ViewBag.Error = error;
            return View("Scores");
        }
    }
}
