using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using Unit2Project.Models;

// This is the Comic Controller that controlls the edit add and delete Views. 
// It also gets the data from the ComicContext class 

namespace Unit2Project.Controllers
{
    public class ComicController : Controller
    {
        private ComicContext context { get; set; }

        public ComicController(ComicContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";
            return View("Edit", new Comic());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var comic = context.Comics.Find(id);
            return View(comic);
        }

        [HttpPost]
        public IActionResult Edit(Comic comic) 
        {
            if (ModelState.IsValid)
            {
                if(comic.ComicId == 0)
                    context.Comics.Add(comic);
                else
                    context.Comics.Update(comic);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (comic.ComicId == 0) ? "Add" : "Edit";
                return View(comic);
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var comic = context.Comics.Find(id);
            return View(comic);
        }
        [HttpPost]
        public IActionResult Delete(Comic comic) 
        {
            context.Comics.Remove(comic);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
