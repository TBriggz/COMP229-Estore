using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class ProductRepository
    {
        public static List<Product> storeProducts = new List<Product>();

        public static IEnumerable<Product> Products
        {
            get
            {
                return storeProducts;
            }
        }

        public static void AddProductToStore(Product product)
        {
            storeProducts.Add(product);
        }

        public static void AddProductsToStore(IEnumerable<Product> products)
        {
            storeProducts.AddRange(products);
        }
    }
}
