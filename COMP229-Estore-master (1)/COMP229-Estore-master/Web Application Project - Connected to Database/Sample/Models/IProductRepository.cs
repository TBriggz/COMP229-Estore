using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Product> getProducts();
        void EditProducts(Product book);
        Product getProduct(int productId);

    }
}
