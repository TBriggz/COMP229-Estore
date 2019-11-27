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
        private IProductRepository repository;

        ProductRepository poo =new ProductRepository();
        List<Product> Products = ProductRepository.storeProducts;

        public HomeController(Cart aCart, IProductRepository repo)
        {
            cart = aCart;
            repository = repo;
        }

        [HttpGet]
        public ViewResult EditPage(int productId)
        {
            Product john=repository.Products.FirstOrDefault(b => b.ProductID == productId);
            return View(john);
        }

        [HttpPost]
        public IActionResult Edit(Product books)
        {
            if (ModelState.IsValid)
            {
                repository.EditProducts(books);
                TempData["message"] = $"{books.ProductID}has been saved";
                return RedirectToAction("DataPage");
            }
            else
            {
                return View(books);
            }
        }
        //public IActionResult DataPage()
        //{
        //    return View(Products);
        //}

        //IList<Product> products = new List<Product>()
        //{


        //};

        [HttpGet]
        public IActionResult DataPage()
        {
            //if (!ProductRepository.storeProducts.Any())
            //{
            //    ItemsInStock.GenerateProducts();
            //}
            //else
            //{
            //    return View();
            //}
            return View(repository);
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
