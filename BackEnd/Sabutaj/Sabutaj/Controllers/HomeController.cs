using Microsoft.AspNetCore.Mvc;

namespace Sabutaj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
