using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public interface IProductsRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
        
    }
}
