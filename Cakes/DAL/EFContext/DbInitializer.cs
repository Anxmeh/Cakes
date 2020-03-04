using Cakes.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.DAL.EFContext
{
  
    public class DbInitializer
    {
        public static void Seed(EFDbContext context)
        {
            if (!context.Categories.Any())
            {
                var category = new Category();
                category.Id = 1;
                category.CategoryName = "Chocolate";
                context.Categories.Add(category);
            }
            context.SaveChanges();

            if (!context.Cakes.Any())
            {
                var cake = new Cake();
                cake.Id = 1;
                cake.Name = "Chocolate cake";
                cake.Image = "https://www.patee.ru/r/x6/0e/bd/f9/640m.jpg";
                cake.Price = 200;
                cake.Weight = 1.5;
                cake.CategoryId = 1;

                context.Cakes.Add(cake);
            };
            context.SaveChanges();
        }

        public static void SeedData(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                DbInitializer.Seed(context);
            }
        }
    }
   
    /*
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //I'm bombing here
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                EFDbContext context = serviceScope.ServiceProvider.GetService<EFDbContext>();
                if (!context.Categories.Any())
                {
                    var category = new Category();
                    category.Id = 1;
                    category.CategoryName = "Chocolate";
                    context.Categories.Add(category);
                }
                context.SaveChanges();

                if (!context.Cakes.Any())
                {
                    var cake = new Cake();
                    cake.Id = 1;
                    cake.Name = "Chocolate cake";
                    cake.Image = "https://www.patee.ru/r/x6/0e/bd/f9/640m.jpg";
                    cake.Price = 200;
                    cake.Weight = 1.5;
                    cake.CategoryId = 1;

                    context.Cakes.Add(cake);
                };
                context.SaveChanges();
            }

        }
    }
    */
}

