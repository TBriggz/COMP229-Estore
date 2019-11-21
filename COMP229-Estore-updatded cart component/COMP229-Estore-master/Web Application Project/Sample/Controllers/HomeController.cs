using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using Sample.Models.ViewModels;

namespace Sample.Controllers
{    
    public class HomeController : Controller
    {
        private Cart cart;

         ProductRepository poo=new ProductRepository();
        List<Product> Products = ProductRepository.storeProducts;

        
        public IActionResult Edit(int Id)
        {

            Product std = Products.Where(s => s.ProductID == Id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public IActionResult Edit(Product std)
        {
            var Id= std.ProductID;
            var name = std.Name;
            var description = std.Description;
            var price = std.Price;
            return RedirectToAction("DataPage");
        }
        //public IActionResult DataPage()
        //{
        //    return View(Products);
        //}

        //IList<Product> products = new List<Product>()
        //{


        //};


        public HomeController(Cart aCart)
        {
            cart = aCart;
        }
        [HttpGet]
        public IActionResult DataPage()
        {
            if (!ProductRepository.storeProducts.Any())
            {
                ItemsInStock.GenerateProducts();
            }
            else
            {
                return View();
            }
            return View();
        }
        
        //[HttpPost]
        //public IActionResult DataPage(Product product)
        //{
        //    //CartItem item = new CartItem();
        //    //item.CartItemID = product.ProductID;
        //    //item.Product = product;
        //    RefreshCart.Refresh(product);
        //    return View("../Order/Cart", RefreshCart.UserCart);
        //}

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
