using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
namespace AyisigiApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult ALogin()
        {
            return View();
        }
    }
}