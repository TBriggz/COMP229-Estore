using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class ProductRepository 
    {
        
        public static List<Product> storeProducts = new List<Product>();

        public List<Product> Products()
        {
            {
                return storeProducts;
            }
        }

       
        public static void AddProductToStore(Product product)
        {
            storeProducts.Add(product);
        }
        public static void RemoveProductFromStore(Product product)
        {
            storeProducts.Remove(product);
        }

        public static void AddProductsToStore(List<Product> products)
        {
            storeProducts.AddRange(products);
        }

        
    }
}
