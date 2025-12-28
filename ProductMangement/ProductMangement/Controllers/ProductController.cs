using Microsoft.AspNetCore.Mvc;
using ProductMangement.Services;

namespace ProductMangement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _ProductServices;
        public ProductController(IProductService productService)
        {
            _ProductServices = productService;
        }

        public IActionResult Index()
        {
            var products = _ProductServices.GetAllProducts();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _ProductServices.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
