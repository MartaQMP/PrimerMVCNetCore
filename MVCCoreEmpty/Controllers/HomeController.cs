using Microsoft.AspNetCore.Mvc;

namespace MVCCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
