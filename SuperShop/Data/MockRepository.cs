﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperShop.Data.DataContext;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "um", Price = 10 });
            products.Add(new Product { Id = 2, Name = "doois", Price = 20 });
            products.Add(new Product { Id = 3, Name = "tres", Price = 30 });
            products.Add(new Product { Id = 4, Name = "quatro", Price = 40 });
            products.Add(new Product { Id = 5, Name = "cinco", Price = 50 });
            return products;
        }

        public bool ProducExits(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
