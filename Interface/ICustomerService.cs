using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Interface {
    public interface ICustomerService { 
        IEnumerable<Customer> Customers();    //get
        Customer Customer(int id);   //getById
        int Customer(Customer customer);  //Add
        int Customer(Customer customer, int id); //update
        bool DeleteCustomer(int id);    //delete
    }
}
