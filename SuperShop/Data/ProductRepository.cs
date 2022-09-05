using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.DataContext;
using SuperShop.Data.Entities;

namespace SuperShop.Data.DataContext
{
    public class ProductRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base (context)
        {
            _context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return _context.Products.Include(p => p.User);
        }
    }
}
