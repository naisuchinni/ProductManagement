using ProductMangement.Models;

namespace ProductMangement.Services
{
    public class ProductServices : IProductService
    {
        private readonly List<Product> _products = new()
        {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High performance laptop with 16GB RAM and 512GB SSD.",
                    price = 90000,
                    category = "Electronics",
                    StockQuantity = 15,
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=600&q=80",
                    Create_date = DateTime.Now.AddMonths(-3),
                    IsActive = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Description = "Latest model smartphone with OLED display and great camera.",
                    price = 35000,
                    category = "Electronics",
                    StockQuantity = 40,
                    ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?auto=format&fit=crop&w=600&q=80",
                    Create_date = DateTime.Now.AddMonths(-1),
                    IsActive = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Noise-cancelling over-ear headphones with Bluetooth connectivity.",
                    price = 7000,
                    category = "Accessories",
                    StockQuantity = 25,
                    ImageUrl = "https://images.unsplash.com/photo-1511367461989-f85a21fda167?auto=format&fit=crop&w=600&q=80",
                    Create_date = DateTime.Now.AddMonths(-6),
                    IsActive = true
                }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
