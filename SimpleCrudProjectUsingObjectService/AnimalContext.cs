using Microsoft.EntityFrameworkCore;
using SimpleCrudProjectUsingObjectService.Model;

namespace SimpleCrudProjectUsingObjectService {

    public class AnimalContext : DbContext {
        public AnimalContext() {
        }

        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options) { }
        public DbSet<AnimalModel> animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=NIKITAS\\SQLEXPRESS;Database=AnimalDB;Trusted_Connection=True;");
            }
        }
    }
}
