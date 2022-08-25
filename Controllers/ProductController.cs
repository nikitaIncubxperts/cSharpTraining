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
        public IActionResult Product() {
            return Ok(iProductService.Products());
        }

        [HttpGet("{id}")]
        public IActionResult Product(int id) {
            return Ok(iProductService.Product(id));
        }

        [HttpPost]
        public IActionResult Product(Product product) {
            return Ok(iProductService.Product(product));
        }

        [HttpPut]
        public IActionResult Product(Product product, int id) {
            return Ok(iProductService.Product(product, id));
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id) {
            return Ok(iProductService.DeleteProduct(id));
        }
    }
}
