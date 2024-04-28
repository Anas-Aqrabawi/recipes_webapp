using Microsoft.AspNetCore.Mvc;

namespace recipes_webapp.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
