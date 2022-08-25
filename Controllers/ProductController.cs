using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using CustomerProductOrderForeignKey.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerProductOrderForeignKey.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {
        public readonly IProductService iProductService;
        public readonly ProductService productService;

        public ProductController(IProductService _iProductService) {
            iProductService = _iProductService;
            productService = new ProductService();
        }

        [HttpGet]
        public IActionResult Customer() {
            return Ok(iProductService.Products());
        }

        [HttpGet("{id}")]
        public IActionResult Customer(int id) {
            return Ok(iProductService.Product(id));
        }

        [HttpPost]
        public IActionResult Customer(Product product) {
            return Ok(iProductService.Product(product));
        }
    }
}
