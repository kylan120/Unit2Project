using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Unit2Project.Models;
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
