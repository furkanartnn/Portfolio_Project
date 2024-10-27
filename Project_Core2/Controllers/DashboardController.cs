using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Statistics";
            ViewBag.v3 = "Statistic Page";
            return View();
        }
    }
}
