﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data.DataContext
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random;
        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Products.Any())
            {
                AddProduct("Iphone X");
                AddProduct("Rato");
                AddProduct("Teclado");
                AddProduct("Monitor");
                await _context.SaveChangesAsync();
            }
        }
        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100)
            });
            
        }
    }
}
