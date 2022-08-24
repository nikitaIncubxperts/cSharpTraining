using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Services {
    public class ProductService : IProductService {
        public Task<Product> AddProduct(Product product) {
            throw new System.NotImplementedException();
        }

        public Product DeleteProduct(int id) {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id) {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts() {
            throw new System.NotImplementedException();
        }

        public Product UpdateProduct(Product product, int id) {
            throw new System.NotImplementedException();
        }
    }
}
