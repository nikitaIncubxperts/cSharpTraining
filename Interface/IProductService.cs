using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Interface {
    public interface IProductService {
        IEnumerable<Product> Products(); //get all
        Product Product(int id); //get by id
        int Product(Product product);  //add
        int Product(Product product, int id); //update
        bool DeleteProduct(int id);  //delete
    }
}
