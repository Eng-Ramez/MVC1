using Microsoft.AspNetCore.Mvc;

namespace Session1.Controllers
{
    public class UsersController : Controller
    {
       public ViewResult getAll() // action
        {

            List <string> user = new List <string>()
            {
                "Ramez","Anas","Ahmad","Bara","Mostafa"
            };
            return View("index", user);
        }
        public ViewResult Create() // action
        {
            return View("Create");
        }
    }
}
