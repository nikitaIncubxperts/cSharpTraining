using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using System.Collections.Generic;
using System.Linq;
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
            var product = productContext.Products.FirstOrDefault(x => x.Id == id);
            return new Product {
                Id = id,
                Name = product.Name,
                Price = product.Price,
            };
        }

        public int Product(Product product) {
            productContext.Products.Add(product);
            productContext.SaveChanges();
            return 1;
        }

        public int Product(Product product, int id) {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> Products() {
            return productContext.Products;
        }
    }
}
