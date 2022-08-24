using System.ComponentModel.DataAnnotations;

namespace CustomerProductOrderForeignKey.Model {
    public class Product {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Price of Product")]
        public decimal Price { get; set; }
    }
}
