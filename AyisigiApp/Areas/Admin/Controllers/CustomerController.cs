using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace AyisigiApp.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CustomerController:Controller
    {
        private readonly IServiceManager _manager;

        public CustomerController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model =_manager.CustomerService.GetAllCustomer(false);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm]Customer customer)
        {
            if(ModelState.IsValid)
            {
                _manager.CustomerService.CreateCustomer(customer);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update([FromRoute(Name ="id")] int id)
        {
            var model=_manager.CustomerService.GetOneCustomer(id,false);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Customer customer)
        {
            if(ModelState.IsValid)
            {
            _manager.CustomerService.UpdateOneCustomer(customer);
            return RedirectToAction("Index");
                
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete([FromRoute(Name ="id")]int id)
        {
            _manager.CustomerService.DeleteOneCustomer(id);
            return RedirectToAction("Index");
        }
    }
}