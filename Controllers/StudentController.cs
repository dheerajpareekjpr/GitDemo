using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
