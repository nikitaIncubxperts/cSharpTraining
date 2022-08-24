using System.ComponentModel.DataAnnotations;

namespace CustomerProductOrderForeignKey.Model {
    public class Customer {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public int LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "E-Mail is not valid")]
        public string? Email { get; set; }
    }
}
