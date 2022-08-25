using CustomerProductOrderForeignKey.Interface;
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
        public IActionResult Get() {
            return Ok(iProductService.Products());
        }
    }
}
