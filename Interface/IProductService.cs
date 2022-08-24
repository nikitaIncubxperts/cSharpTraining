using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Interface {
    public interface IProductService {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Task<Product> AddProduct(Product product);
        Product UpdateProduct(Product product, int id);
        Product DeleteProduct(int id);
    }
}
