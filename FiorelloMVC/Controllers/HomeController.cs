using Microsoft.AspNetCore.Mvc;

namespace FiorelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}