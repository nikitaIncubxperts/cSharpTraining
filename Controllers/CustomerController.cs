using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerProductOrderForeignKey.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        private readonly ICustomerService icustomerService;
        private readonly CustomerService customerServiceObj;
        public CustomerController(ICustomerService _icustomerService) { 
            icustomerService = _icustomerService;
            customerServiceObj = new CustomerService();
        }
        [HttpGet]
        public IActionResult Colleges() {
            return Ok(icustomerService.Customers());
        }
    }
}
