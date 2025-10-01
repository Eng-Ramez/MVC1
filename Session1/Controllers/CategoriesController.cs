using Microsoft.AspNetCore.Mvc;
using Session1.Data;

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
    }
}
