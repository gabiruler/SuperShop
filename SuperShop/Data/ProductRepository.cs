using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperShop.Data.DataContext;
using SuperShop.Data.Entities;

namespace SuperShop.Data.DataContext
{
    public class ProductRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProductRepository(DataContext context) : base (context)
        {

        }
    }
}
