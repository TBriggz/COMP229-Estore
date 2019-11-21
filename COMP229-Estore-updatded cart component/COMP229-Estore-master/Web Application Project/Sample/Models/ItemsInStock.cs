using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class ItemsInStock : ProductRepository
    {
        public static void GenerateProducts() 
        {
            storeProducts.Add(
            new Product
            {
                ProductID = 1, 
                Name = "Headphones", 
                Description = "Over-ear Bluetooth Headphones", 
                Price = 69.99M
            });
            storeProducts.Add(
            new Product
            {
                ProductID = 2,
                Name = "Smartwatch",
                Description = "Smartwatch with Fitness Tracking",
                Price = 199.99M
            });
            storeProducts.Add(
            new Product
            {
                ProductID = 3,
                Name = "Sony Smart TV",
                Description = "Sony 49in. HD LED Android Smart TV",
                Price = 549.99M
            });
            storeProducts.Add(
            new Product
            {
                ProductID = 4,
                Name = "Apple iPad",
                Description = "Apple iPad 10.2in. 32GB Space",
                Price = 429.99M
            });
            storeProducts.Add(
            new Product
            {
                ProductID = 5,
                Name = "Chromebook",
                Description = "HP Chromebook 14in. Touchscreen",
                Price = 229.99M
            });
        }
    }
}
