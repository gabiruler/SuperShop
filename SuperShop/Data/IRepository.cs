using System.Collections.Generic;
using System.Threading.Tasks;
using SuperShop.Data.Entities;

namespace SuperShop.Data.DataContext
{
    public interface IRepository
    {
        void AddProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        bool ProducExits(int id);
        void RemoveProduct(Product product);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Product product);
    }
}