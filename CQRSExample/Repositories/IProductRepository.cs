using CQRSExample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSExample.Repositories
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int id);
        Task<List<Product>> GetAllProductsAsync();
    }
}
