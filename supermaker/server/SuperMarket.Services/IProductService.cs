using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Core.Models;

namespace SuperMarket.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<Product> AddProduct(Product Product);
        Task UpdateProduct(Product Product);
        Task DeleteProduct(int ProductId);
    }
}