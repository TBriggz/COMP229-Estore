using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult DataPage()
        {
            return View();
        }
 
        public IActionResult SettingsPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View(new CustomerDetails());
        }

        [HttpPost]
        public IActionResult Insert(CustomerDetails obj)
        {
            FakeRepository.AddNewCustomer(obj);

            //return View("DisplayPage", FakeRepository.GetCustomer());
            return View("GreetingPage");
        }
        public IActionResult ItemsList()
        {
            return View(FakeRepository.GetCustomer());
        }
        public IActionResult DisplayPage()
        {
            return View(FakeRepository.GetCustomer());
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
