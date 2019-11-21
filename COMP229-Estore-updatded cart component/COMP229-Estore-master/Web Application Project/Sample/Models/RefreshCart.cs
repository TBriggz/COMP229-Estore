using Sample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class RefreshCart 
    {
        //public static List<Product> UserProducts = new List<Product>();
        public static CartViewModel UserCart = new CartViewModel();
        public static void Refresh(Product product)
        {
            //UserProducts.Add(product);
            //for (int aProduct = 0; aProduct < UserProducts.Count; aProduct++)
            //{
            //    UserCart.Cart.AddItem(UserProducts[aProduct], 1);
            //}
            UserCart.Cart.AddItem(product, 1);
           
        }
        public static void Delete(Product product)
        {
             UserCart.Cart.RemoveItem(product);
        }

        public CartViewModel GetCart()
        {
            return UserCart;
        }
    }
 
}
