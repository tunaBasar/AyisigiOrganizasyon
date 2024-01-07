using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace AyisigiApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IServiceManager _manager;

        public CustomerController(IServiceManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ULogin()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([FromForm]Customer customer)
        {
            if(ModelState.IsValid)
            {
                _manager.CustomerService.CreateCustomer(customer);
                return RedirectToAction("ULogin");
            }
            return View();
        }

    }
}