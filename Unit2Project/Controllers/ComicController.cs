using Microsoft.AspNetCore.Mvc;

namespace Unit2Project.Controllers
{
    public class ComicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
