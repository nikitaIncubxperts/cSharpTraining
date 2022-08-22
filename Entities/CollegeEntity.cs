using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites {
    public class CollegeEntity {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string District { get; set; }
    }
}
