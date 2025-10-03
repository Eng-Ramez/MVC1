using Microsoft.AspNetCore.Mvc;
using Session1.Data;
using Session1.Models;

namespace Session1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public ViewResult Index()
        {
            var category = context.categories.ToList();

            return View("index", category);
        }
        public ViewResult details(int Id)
        {
            var getCat = context.categories.Find(Id);

            return View("details", getCat);
        }
        public ViewResult Create() 
        {
            return View("Create",new Category());
        
        }
        public IActionResult Add(Category request) 
        {
            if (ModelState.IsValid)
            {
            context.categories.Add(request);
            context.SaveChanges();

                return RedirectToAction("Index");

            }
            return View("Create", request);  
        }
        public IActionResult Delete(int id)
        {
            var found = context.categories.Find(id);
            if (found == null)
            {
             return View("NotFound");
            }
            context.categories.Remove(found);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var found = context.categories.Find(id);
            return View(found);
        }
        public IActionResult Update(Category request)
        {
            if (ModelState.IsValid)
            {
                context.categories.Update(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", request);

        }


    }
}
