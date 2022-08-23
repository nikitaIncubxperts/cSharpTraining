using Microsoft.EntityFrameworkCore;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using System.Collections.Generic;
using System.Linq;
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

        public StudentEntity DeleteStudentById(int id) {
            var delStudentData = _stud_clg_context.studentData.FirstOrDefault(x => x.Id == id);
            if (delStudentData != null) {
                var delStud = _stud_clg_context.studentData.Remove(delStudentData);
                _stud_clg_context.SaveChanges();
                return delStud.Entity;
            }
            return null;
        }

        public IEnumerable<StudentEntity> GetAllStudents() {
            return _stud_clg_context.studentData;
        }

        public StudentEntity GetStudentById(int id) {
            var studById = _stud_clg_context.studentData.FirstOrDefault(x => x.Id == id);
            _stud_clg_context.SaveChanges();
            return studById;
        }

        public StudentEntity UpdateStudent(StudentEntity student, int id) {
            var studentData = _stud_clg_context.studentData.Where(x => x.Id == id).ToList();
            foreach(var dataUpdate in studentData) {
                if(dataUpdate.Id == id) {
                    dataUpdate.FirstName = student.FirstName;
                    dataUpdate.LastName = student.LastName;
                    dataUpdate.Email = student.Email;
                    dataUpdate.Phone = student.Phone;
                    dataUpdate.DateOfBirth = student.DateOfBirth;

                    var studUpdate = _stud_clg_context.studentData.Update(dataUpdate);
                    _stud_clg_context.SaveChanges();
                    return studUpdate.Entity;
                }
            }
            return null;
        }
    }
}
