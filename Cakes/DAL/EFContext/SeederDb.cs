using Cakes.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.DAL.EFContext
{
    public class SeederDb
    {

        public static void SeedRoles(RoleManager<DbRole> _roleManager)
        {
            var count = _roleManager.Roles.Count();

            if (count <= 0)
            {
                var roleName = "User";
                var result = _roleManager.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;

                roleName = "Admin";
                result = _roleManager.CreateAsync(new DbRole
                {
                    Name = roleName
                }).Result;
            }
        }

        public static void SeedUsers(UserManager<DbUser> _userManager,
                                    EFDbContext _context)
        {
            var count = _userManager.Users.Count();

            if (count <= 0)
            {
                string mail = "anx.meh@gmail.com";
                var roleName = "Admin";
                var user = new DbUser
                {
                    Email = mail,
                    UserName = mail,
                    PhoneNumber = "+380638177501"
                };

                var result = _userManager.CreateAsync(user, "Qwerty-1").Result;

                var userProfile = new UserProfile
                {
                    Id = user.Id,
                    FirstName = "Olga",
                    MiddleName = "Anatoliyivna",
                    LastName = "Makarova",
                    RegistrationDate = DateTime.Now
                };

                _context.UserProfile.Add(userProfile);
                _context.SaveChanges();
                result = _userManager.AddToRoleAsync(user, roleName).Result;


                mail = "user1@gmail.com";
                roleName = "User";
                var user2 = new DbUser
                {
                    Email = mail,
                    UserName = mail,
                    PhoneNumber = "+380681234567"
                };

                result = _userManager.CreateAsync(user2, "Qwerty-2").Result;

                var userProfile2 = new UserProfile
                {
                    Id = user2.Id,
                    FirstName = "Semen",
                    MiddleName = "Semenovuch",
                    LastName = "Semenuk",
                    RegistrationDate = DateTime.Now
                };

                _context.UserProfile.Add(userProfile2);
                _context.SaveChanges();
                result = _userManager.AddToRoleAsync(user2, roleName).Result;

                mail = "user2@gmail.com";
                roleName = "User";

                var user3 = new DbUser
                {
                    Email = mail,
                    UserName = mail,
                    PhoneNumber = "+380639876541"
                };

                result = _userManager.CreateAsync(user3, "Qwerty-3").Result;

                var userProfile3 = new UserProfile
                {
                    Id = user3.Id,
                    FirstName = "Ivan",
                    MiddleName = "Ivanovych",
                    LastName = "Ivanov",
                    RegistrationDate = DateTime.Now
                };

                _context.UserProfile.Add(userProfile3);
                _context.SaveChanges();
                result = _userManager.AddToRoleAsync(user3, roleName).Result;

                mail = "user3@gmail.com";
                roleName = "User";
                var user4 = new DbUser
                {
                    Email = mail,
                    UserName = mail,
                    PhoneNumber = "+380632581479"
                };

                result = _userManager.CreateAsync(user4, "Qwerty-4").Result;

                var userProfile4 = new UserProfile
                {
                    Id = user4.Id,
                    FirstName = "Anna",
                    MiddleName = "Dmytrivna",
                    LastName = "Semenuk",
                    RegistrationDate = DateTime.Now
                };

                _context.UserProfile.Add(userProfile4);
                _context.SaveChanges();
                result = _userManager.AddToRoleAsync(user4, roleName).Result;
            }
        }

        public static void SeedCategories(EFDbContext _context)
        {
            if (!_context.Categories.Any())
            {
                var category = new Category();
                category.CategoryName = "Chocolate cakes";
                _context.Categories.Add(category);
                _context.SaveChanges();

                var category2 = new Category();
                category2.CategoryName = "Fruit cakes";
                _context.Categories.Add(category2);
                _context.SaveChanges();

                var category3 = new Category();
                category3.CategoryName = "Mousse cakes";
                _context.Categories.Add(category3);
                _context.SaveChanges();

                var category4 = new Category();
                category4.CategoryName = "Marshmallows";
                _context.Categories.Add(category4);
                _context.SaveChanges();
            }

        }

        public static void SeedCakes(EFDbContext _context)
        {
            if (!_context.Cakes.Any())
            {
                var cake = new Cake();
                cake.Name = "Prague";
                cake.Image = @"\images\praga.jpg";
                cake.Price = 200;
                cake.Weight = 1.5;
                cake.CategoryId = 10;
                _context.Cakes.Add(cake);
                _context.SaveChanges();

                var cake2 = new Cake();
                cake2.Name = "Black Forest";
                cake2.Image = @"\images\blackForest.jpg";
                cake2.Price = 300;
                cake2.Weight = 1.5;
                cake2.CategoryId = 10;
                _context.Cakes.Add(cake2);
                _context.SaveChanges();

                var cake3 = new Cake();
                cake3.Name = "Berries Marshmallow";
                cake3.Image = @"\images\berriesM.jpg";
                cake3.Price = 10;
                cake3.Weight = 0.05;
                cake3.CategoryId = 13;
                _context.Cakes.Add(cake3);
                _context.SaveChanges();

                var cake4 = new Cake();
                cake4.Name = "Lime Marshmallow";
                cake4.Image = @"\images\limeM.jpg";
                cake4.Price = 10;
                cake4.Weight = 0.05;
                cake4.CategoryId = 13;
                _context.Cakes.Add(cake4);
                _context.SaveChanges();

                var cake5 = new Cake();
                cake5.Name = "Vanilla Marshmallow";
                cake5.Image = @"\images\vanillaM.jpg";
                cake5.Price = 10;
                cake5.Weight = 0.05;
                cake5.CategoryId = 13;
                _context.Cakes.Add(cake5);
                _context.SaveChanges();

                var cake6 = new Cake();
                cake6.Name = "Three Chokolates";
                cake6.Image = @"\images\3chokolates.jpg";
                cake6.Price = 250;
                cake6.Weight = 1.5;
                cake6.CategoryId = 12;
                _context.Cakes.Add(cake6);
                _context.SaveChanges();

                var cake7 = new Cake();
                cake7.Name = "Bird's Milk";
                cake7.Image = @"\images\birdsMilk.jpg";
                cake7.Price = 200;
                cake7.Weight = 1.6;
                cake7.CategoryId = 12;
                _context.Cakes.Add(cake7);
                _context.SaveChanges();

            };
        }

        public static void SeedData(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var user_manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();

                SeederDb.SeedRoles(managerRole);
                SeederDb.SeedUsers(user_manager, context);
                SeederDb.SeedCategories(context);
                SeederDb.SeedCakes(context);
            }
        }
    }
}
