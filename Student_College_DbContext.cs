using Microsoft.EntityFrameworkCore;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI {
    public class Student_College_DbContext : DbContext {

        public Student_College_DbContext(DbContextOptions<Student_College_DbContext> options) : base(options) { }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<CollegeEntity> Colleges { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NIKITAS\\SQLEXPRESS;Database=StudentCollegeDB;Trusted_Connection=True;");
            }
        }
    }
}