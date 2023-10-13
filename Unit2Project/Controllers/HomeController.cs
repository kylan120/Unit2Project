using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Unit2Project.Models;

// This is the Home Controller that controls the Index page

namespace Unit2Project.Controllers
{
    public class HomeController : Controller
    {
        private ComicContext context { get; set; }

        public HomeController(ComicContext ctx) 
        {
            context = ctx;
        } 
        public IActionResult Index()
        {
            var comics = context.Comics.ToList();
            return View(comics);
        }
    }
}
