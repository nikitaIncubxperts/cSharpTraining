using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerProductOrderForeignKey.Services {
    public class ProductService : IProductService {
        private readonly CustomerProductOrderDbContext productContext;

        public ProductService() {
            productContext = new CustomerProductOrderDbContext();
        }
        public bool DeleteProduct(int id) {
            throw new System.NotImplementedException();
        }

        public Product Product(int id) {
            throw new System.NotImplementedException();
        }

        public int Product(Product product) {
            throw new System.NotImplementedException();
        }

        public int Product(Product product, int id) {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> Products() {
            return productContext.Products;
        }
    }
}
