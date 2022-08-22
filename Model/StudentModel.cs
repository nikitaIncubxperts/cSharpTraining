using System;
using System.ComponentModel.DataAnnotations;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Model {
    public class StudentModel {

       
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        
        [Required]
        public int CollegeId { get; set; }
    }
}
