using Microsoft.AspNetCore.Mvc;

namespace AyisigiApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}