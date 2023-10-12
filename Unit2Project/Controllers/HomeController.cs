using Microsoft.AspNetCore.Mvc;

namespace Unit2Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
