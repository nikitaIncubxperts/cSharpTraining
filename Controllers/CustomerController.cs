using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
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
        [HttpGet("{id}")]
        public IActionResult College(int id) {
            return Ok(icustomerService.Customer(id));
        }
        [HttpPost]
        public IActionResult Customer(Customer customer) {
            return Ok(icustomerService.Customer(customer));
        }
        [HttpPut]
        public IActionResult Customer(Customer customer, int id) { 
            return Ok(icustomerService.Customer(customer, id));
        }
        [HttpDelete]
        public IActionResult Customer(int id) {
            return Ok(icustomerService.DeleteCustomer(id));
        }
    }
}
