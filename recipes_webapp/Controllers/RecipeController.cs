using Microsoft.AspNetCore.Mvc;

namespace recipes_webapp.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
