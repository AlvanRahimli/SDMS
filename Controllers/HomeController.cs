using Microsoft.AspNetCore.Mvc;

namespace SDMS.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}