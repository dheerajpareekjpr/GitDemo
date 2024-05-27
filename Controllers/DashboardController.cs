using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
