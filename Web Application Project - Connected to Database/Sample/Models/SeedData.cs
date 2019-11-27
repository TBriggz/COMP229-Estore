using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Sample.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Headphones",
                    Description = "Over-ear Bluetooth Headphones",
                    Price = 69.99M                    
                },
                new Product
                {
                    Name = "Smartwatch",
                    Description = "Smartwatch with Fitness Tracking",
                    Price = 199.99M
                },
                new Product
                {
                    Name = "Sony Smart TV",
                    Description = "Sony 49in. HD LED Android Smart TV",
                    Price = 549.99M
                },
                new Product
                {
                    Name = "Apple iPad",
                    Description = "Apple iPad 10.2in.32GB Space",
                    Price = 429.99M
                },
                new Product
                {
                    Name = "Chromebook",
                    Description = "HP Chromebook 14in. Touchscreen",
                    Price = 229.99M
                },
                new Product
                {
                    Name = "GoPro Hero 8",
                    Description = "Waterproof 4k Sports and Camera",
                    Price = 529.99M
                },
                new Product
                {
                    Name = "DJI Mavic 2 Pro Quadcopter Drone",
                    Description = "with Camera and Controller - Ready to Fly",
                    Price = 1869.99M
                },
                new Product
                {
                    Name = "Fujifilm Instax Mini 9",
                    Description = "Snap instant, retro inspired photos and selfies",
                    Price = 89.99M
                },
                new Product
                {
                    Name = "Arlo Pro Wire-Free Security System with 4 HD Cameras",
                    Description = "Keep an eye on your home, business, or mischievous pets security system",
                    Price = 599.99M
                }
            );
                
            }
            context.SaveChanges();
        }
    }
}
