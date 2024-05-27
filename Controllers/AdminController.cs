using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
