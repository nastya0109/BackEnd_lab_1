using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
