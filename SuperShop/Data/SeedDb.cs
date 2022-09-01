using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using SuperShop.Helpers;

namespace SuperShop.Data.DataContext
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userhelper;
        private Random _random;
        public SeedDb(DataContext context, IUserHelper userhelper)
        {
            _context = context;
            _userhelper = userhelper;
            _random = new Random();
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userhelper.GetUserByEmailAsync("gabiruler@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Gabriel",
                    LastName = "Garcia",
                    Email = "gabiruler@gmail.com",
                    UserName = "gabiruler@gmail.com",
                    PhoneNumber = "910392687"

                };
                var result = await _userhelper.AddUserAsync(user, "123456");
                if(result!= IdentityResult.Success)
                {
                    throw new InvalidOperationException("Error: Could not create user in seeder");
                }
            }


            if (!_context.Products.Any())
            {
                AddProduct("Iphone X", user);
                AddProduct("Rato", user);
                AddProduct("Teclado", user);
                AddProduct("Monitor", user);
                await _context.SaveChangesAsync();
            }
        }
        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User = user 
            });
            
        }
    }
}
