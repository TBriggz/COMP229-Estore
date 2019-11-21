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
        private Cart cart;

        

       
 
        public OrderController(Cart aCart)
        {
            cart = aCart;
        }
        public ViewResult DataPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View("Cart", RefreshCart.UserCart);
        }
       

        public RedirectToActionResult AddToCart(int productId)
        {
            //Product product = ProductRepository.storeProducts
            //.FirstOrDefault(p => p.ProductID == productId);
            //if (product != null)
            //{
            //    RefreshCart.Refresh(product);
            //}
            for(int aProduct = 0; aProduct < ProductRepository.storeProducts.Count; aProduct++)
            {
                if(ProductRepository.storeProducts[aProduct].ProductID == productId)
                {
                    RefreshCart.Refresh(ProductRepository.storeProducts[aProduct]);
                }
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromCart(int productId)
        {
            for (int aProduct = 0; aProduct < ProductRepository.storeProducts.Count; aProduct++)
            {
                if (ProductRepository.storeProducts[aProduct].ProductID == productId)
                {
                    RefreshCart.Delete(ProductRepository.storeProducts[aProduct]);
                }
            }
            return RedirectToAction("Index");
        }

        public ViewResult Checkout()
        {
            return View();
        }

    }
}