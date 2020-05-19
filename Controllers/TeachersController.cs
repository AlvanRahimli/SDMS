using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SDMS.Repos.Courses;
using SDMS.Repos.Teachers;

namespace SDMS.Controllers
{
    [Controller]
    [Route("[controller]")]
    [Authorize(Roles = "teacher")]
    public class TeachersController : Controller
    {
        private readonly ITeachersRepo _repo;
        private readonly ICoursesRepo _cRepo;

        public TeachersController(ITeachersRepo repo, ICoursesRepo cRepo)
        {
            this._repo = repo;
            this._cRepo = cRepo;
        }

        [HttpGet]
        [Route("Courses")]
        public async Task<IActionResult> Courses()
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var repoResponse = await _repo.LoadCourses(idGuid);

            if (!repoResponse.IsSuccess)
            {
                return RedirectToAction(
                    actionName: "GetProfile",
                    controllerName: "Auth"
                );
            }

            return View("Courses", repoResponse.Content);
        }

        [HttpGet]
        [Route("Students")]
        public async Task<IActionResult> Students()
        {
            var id = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var idGuid = Guid.Parse(id);

            var result = await _cRepo.GetCoursesBrief(idGuid);

            if (result.IsSuccess)
            {
                ViewBag.Courses = result.Content;
                ViewBag.Action = "Students";
                ViewBag.Controller = "Teachers";
                return View("SelectCourse");
            }

            return RedirectToAction("Students");
        }

        [HttpPost]
        [Route("Students")]
        public async Task<IActionResult> Students(Guid courseId)
        {
            if (courseId == Guid.Empty)
                return RedirectToAction("Students");
            
            var response = await _cRepo.GetStudentList(courseId);
            var response2 = await _cRepo.GetCourse(courseId);

            if (response.IsSuccess)
            {
                ViewBag.Course = response2.Content.Name;
                ViewBag.CourseId = response2.Content.Id;
                ViewBag.Error = "";
                ViewBag.Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                return View("StudentList", response.Content);
            }

            return View("Oops");
        }
    
        [HttpGet]
        [Route("Evaluate")]
        public async Task<IActionResult> Evaluate(Guid sId, Guid cId, DateTime date, int score)
        {
            if (sId == Guid.Empty || cId == Guid.Empty || score - 100 > 0)
            {
                return RedirectToAction("Students");
            }

            var response = await _cRepo.GetStudentList(cId);
            var response1 = await _cRepo.GetCourse(cId);
            var result = await _repo.EvaluateStudent(sId, cId, date, score);

            if (result.IsSuccess)
            {
                ViewBag.Course = response1.Content.Name;
                ViewBag.CourseId = response1.Content.Id;
                ViewBag.Error = "";
                ViewBag.Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                return View("StudentList", response.Content);
            }
            
            return View("Oops");
        }
    
        [HttpGet]
        [Route("WriteAttendance")]
        public async Task<IActionResult> WriteAttendance(Guid sId, Guid cId, DateTime date)
        {
            if (sId == Guid.Empty || cId == Guid.Empty)
            {
                return RedirectToAction("Students");
            }

            var response = await _cRepo.GetStudentList(cId);
            var response1 = await _cRepo.GetCourse(cId);
            var result = await _repo.WriteAttendance(sId, cId, date);

            if (result.IsSuccess)
            {
                ViewBag.Course = response1.Content.Name;
                ViewBag.CourseId = response1.Content.Id;
                ViewBag.Error = "";
                ViewBag.Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                return View("StudentList", response.Content);
            }

            return View("Oops");
        }
    }
}