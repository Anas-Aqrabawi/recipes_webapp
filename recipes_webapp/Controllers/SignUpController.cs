using Microsoft.AspNetCore.Mvc;

namespace recipes_webapp.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
