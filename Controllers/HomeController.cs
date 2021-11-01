using ChrisCafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisCafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
                List<Customer> result = null;
                using (CustomerContext context = new CustomerContext())
                {
                    result = context.Customers.ToList();
                }


            
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Registration()
        {
            
           
            return View();
        }
        public IActionResult DisplayUsers()
        {
            List<Customer> result = null;
            using (CustomerContext context = new CustomerContext())
            {
                result = context.Customers.ToList();
            }



            return View(result);

            
        }
        public IActionResult Result(string fname)
        {
            ViewData["Result"] = $"Welcome {fname}";
            return View();
        }
        public IActionResult SaveCustomer(Customer c)
        {
            using (CustomerContext context = new CustomerContext())
            {
                context.Customers.Add(c);
                context.SaveChanges();

            }

            return Redirect("/");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
