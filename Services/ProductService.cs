using CustomerProductOrderForeignKey.Interface;
using CustomerProductOrderForeignKey.Model;
using System;
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
            var product = productContext.Products.FirstOrDefault(x => x.Id == id);
            if (product != null) {
                productContext.Products.Remove(product);
                productContext.SaveChanges();
            } else {
                Console.WriteLine("No such product for delete");
            }
            return true;
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
            try {
                var result = productContext.Products.FirstOrDefault(a => a.Id == product.Id);
                if (result != null) {
                    result.Name = product.Name;
                    result.Price = product.Price;;
                    productContext.SaveChangesAsync();
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return 1;
        }

        public IEnumerable<Product> Products() {
            return productContext.Products;
        }
    }
}
