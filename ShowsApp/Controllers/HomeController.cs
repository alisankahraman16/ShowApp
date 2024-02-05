using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShowsApp.Models;

namespace ShowsApp.Controllers;

public class HomeController : Controller
{
    

    public HomeController()
    {
    }
    
    [HttpGet]

    public IActionResult Index(string searchString, string category)
    {
        var shows = Repository.Shows;
        if(!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            shows = shows.Where(s => s.ShowTitle.ToLower().Contains(searchString)).ToList();
        }

        if(!String.IsNullOrEmpty(category) && category != "0")
        {
            shows = shows.Where(s => s.CategoryId == int.Parse(category)).ToList();
        }
        // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);

        var model = new ShowViewModel{
            Shows = shows,
            Categories = Repository.Categories,
            SelectedCategory  = category
        };

        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Show model)
    {
        Repository.CreateShow(model);
        return RedirectToAction("Index");
    }
}
