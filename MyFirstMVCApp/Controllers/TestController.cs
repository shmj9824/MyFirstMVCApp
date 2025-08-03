using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}
