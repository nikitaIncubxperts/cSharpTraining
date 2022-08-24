using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using Microsoft.EntityFrameworkCore;
using System;
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
            var AllCustomer = customerProductOrderDbContext.Customers.ToList();
            return AllCustomer;
        }

        public Customer Customer(int id) {
            var customer = customerProductOrderDbContext.Customers.FirstOrDefault(x => x.Id == id);
            return new Customer {
                Id = id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Phone = customer.Phone,
            };
        }

        public int Customer(Customer customer) {
            customerProductOrderDbContext.Customers.Add(customer);
            customerProductOrderDbContext.SaveChanges();
            return 1;
        }

        public int Customer(Customer customer, int id) {
            try {
                var result = customerProductOrderDbContext.Customers.FirstOrDefault(a => a.Id == customer.Id);
                if (result != null) {
                    result.FirstName = customer.FirstName;
                    result.LastName = customer.LastName;
                    result.Email = customer.Email;
                    result.Phone = customer.Phone;
                    customerProductOrderDbContext.SaveChangesAsync();
                }     
            } catch(Exception e) {
                Console.WriteLine(e);
            }
            return 1;
        }

        public bool DeleteCustomer(int id) {
            var customer = customerProductOrderDbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null) {
                customerProductOrderDbContext.Customers.Remove(customer);
                customerProductOrderDbContext.SaveChanges();
            }
            return true;
        }        
    }
}
