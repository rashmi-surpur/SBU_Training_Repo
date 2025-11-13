using Microsoft.AspNetCore.Mvc;

namespace GitExample5.Controllers
{
    public class Sample1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
