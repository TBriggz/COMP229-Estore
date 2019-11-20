using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Cart()
        {
            return View("Cart", new Cart());
        }
   

        public ViewResult Checkout()
        {
            return View();
        }

    }
}