using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Services {
    public class CustomerService : ICustomerService {
        public readonly CustomerProductOrderDbContext customerProductOrderDbContext;
        public CustomerService() {
            customerProductOrderDbContext = new CustomerProductOrderDbContext();
        }
        public IEnumerable<Customer> Customers() {
            var AllCustomer = customerProductOrderDbContext.Customer.ToList();
            return AllCustomer;
        }

        public Customer Customer(int id) {
            throw new System.NotImplementedException();
        }

        public int Customer(Customer customer) {
            throw new System.NotImplementedException();
        }

        public int Customer(Customer customer, int id) {
            throw new System.NotImplementedException();
        }

        public bool DeleteCustomer(int id) {
            throw new System.NotImplementedException();
        }

        //public Task<Customer> AddCustomer(Customer customer) {
        //    throw new System.NotImplementedException();
        //}

        //public Customer DeleteCustomer(int id) {
        //    throw new System.NotImplementedException();
        //}

        //public Customer GetCustomerById(int id) {
        //    throw new System.NotImplementedException();
        //}

        //public IEnumerable<Customer> GetCustomer() {
        //    var AllCustomer = customerProductOrderDbContext.Customer.ToList();
        //    return AllCustomer;
        //}

        //public Customer UpdateCustomer(Customer customer, int id) {
        //    throw new System.NotImplementedException();
        //}
    }
}
