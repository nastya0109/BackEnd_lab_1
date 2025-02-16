using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
