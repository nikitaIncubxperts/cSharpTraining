using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCrudProjectUsingObjectService.Model {
    public class AnimalModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]        
        public int age { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
}
