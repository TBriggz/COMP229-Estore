using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class Cart
    {
        private List<CartItem> cartItems = new List<CartItem>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartItem item = cartItems
            .Where(p => p.Product.ProductID == product.ProductID)
            .FirstOrDefault();
            if (item == null)
            {
                cartItems.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveItem(Product product) =>
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
    }
}
