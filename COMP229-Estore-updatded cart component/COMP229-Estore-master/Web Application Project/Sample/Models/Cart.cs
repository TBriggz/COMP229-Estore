using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Sample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class Cart
    {
        public static List<CartItem> cartItems = new List<CartItem>();
        [JsonIgnore]
        public ISession Session { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            //ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            //.HttpContext.Session;
            //Cart cart = session?.GetJson<Cart>("Cart")
            //?? new Cart();
            //cart.Session = session;
            return new Cart();
        }

        public void AddItem(Product product, int quantity)
        {
            //CartItem item = cartItems
            //.Where(p => p.Product.ProductID == product.ProductID)
            //.FirstOrDefault();
            //if (cartItems == null)
            //{
            //    cartItems.Add(new CartItem
            //    {
            //        Product = product,
            //        Quantity = quantity
            //    });
            //}
            //else 
            //{
            //    item.Quantity += quantity;
            //}
            cartItems.Add(new CartItem
            {
                Product = product,
                Quantity = quantity
            });
        }

        public void RemoveItem(Product product) =>
        cartItems.RemoveAll(l => l.Product.ProductID == product.ProductID);
        public virtual decimal GetTotalCost() =>
        cartItems.Sum(p => p.Product.Price * p.Quantity);
        public virtual void EmptyCart() => cartItems.Clear();
        public virtual IEnumerable<CartItem> GetItems => cartItems;

    }
    public class CartItem
    {
        public int CartItemID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem() { }
        public CartItem(Product product)
        {
            Product = product;
        }
        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
