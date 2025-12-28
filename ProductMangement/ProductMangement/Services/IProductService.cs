using ProductMangement.Models;

namespace ProductMangement.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
    }
}
