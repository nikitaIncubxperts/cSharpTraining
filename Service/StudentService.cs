using Microsoft.EntityFrameworkCore;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Service {
    public class StudentService : IStudent {
        private readonly IStudentDA studentContext;
        public StudentService(IStudentDA _StudentContext) {
            studentContext = _StudentContext;
        }

        public async Task<StudentModel> AddStudent(StudentModel stu) {

            var obj = new StudentEntity {

                FirstName = stu.FirstName,
                LastName = stu.LastName,
                Email = stu.Email,
                DateOfBirth = stu.DateOfBirth,
                CollegeId = stu.CollegeId,
                Phone = stu.Phone,
            };

            var dataAdd = await studentContext.AddStudent(obj);
            return new StudentModel { Id = dataAdd.Id};
        }

        public StudentModel DeleteStudentById(int id) {
            var studentDelete = studentContext.DeleteStudentById(id);
            return new StudentModel {
                Id = studentDelete.Id
            };
        }

        public IEnumerable<StudentModel> GetAllStudents() {
            var AllStudents = studentContext.GetAllStudents();
            return (from students in AllStudents
                select new StudentModel  {
                    Id = students.Id,
                    FirstName = students.FirstName,
                    LastName= students.LastName,
                    Email = students.Email,
                    Phone = students.Phone,
                    DateOfBirth = students.DateOfBirth,
                });
        }

        public StudentModel GetStudentById(int id) {
            var getStudent = studentContext.GetStudentById(id);
            return new StudentModel {
                Id = getStudent.Id
            };
        }

        public StudentModel UpdateStudent(StudentModel student, int id) {
            var obj = new StudentEntity {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                Phone = student.Phone,
                DateOfBirth = student.DateOfBirth,
            };
            var updateData = studentContext.UpdateStudent(obj, id);
            return new StudentModel {
                Id = updateData.Id,
            };
        }
    }
}
