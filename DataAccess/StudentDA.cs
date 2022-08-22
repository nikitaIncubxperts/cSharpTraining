using Microsoft.EntityFrameworkCore;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess {
    public class StudentDA : IStudentDA {
        private readonly Student_College_DbContext _stud_clg_context;

        public StudentDA(Student_College_DbContext context) {
            _stud_clg_context = context;
        }
        public async Task<StudentEntity> AddStudent(StudentEntity stud) {
            var dataAdd = await _stud_clg_context.studentData.AddAsync(stud);
            _stud_clg_context.SaveChanges();
            return dataAdd.Entity;
        }

        public Task<StudentEntity> DeleteStudentById(int id) {
            throw new System.NotImplementedException();
        }

        public IEnumerable<StudentEntity> GetAllStudents() {
            return _stud_clg_context.studentData;
        }

        public Task<StudentEntity> GetStudentById(int id) {
            throw new System.NotImplementedException();
        }

        public Task<StudentEntity> UpdateStudent(StudentEntity student) {
            throw new System.NotImplementedException();
        }
    }
}
