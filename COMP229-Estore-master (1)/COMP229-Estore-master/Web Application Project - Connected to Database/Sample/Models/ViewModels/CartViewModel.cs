using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models.ViewModels
{
    public class CartViewModel : RefreshCart
    {
        public Cart Cart { get; set; } = new Cart();

        public CartViewModel()
        {
            Cart = new Cart();
        }
    }
}
