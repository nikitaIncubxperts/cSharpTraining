using System.ComponentModel.DataAnnotations;

namespace CustomerProductOrderForeignKey.Model {
    public class Customer {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter FirstName")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter LastName")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "E-Mail is not valid")]
        public string? Email { get; set; }
    }
}
