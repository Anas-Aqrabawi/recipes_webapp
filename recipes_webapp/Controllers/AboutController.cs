using Microsoft.AspNetCore.Mvc;

namespace recipes_webapp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
