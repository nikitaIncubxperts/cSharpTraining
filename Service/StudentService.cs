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
        private readonly IStudentDA StudentContext;
        public StudentService(IStudentDA _StudentContext) {
            StudentContext = _StudentContext;
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

            var dataAdd = await StudentContext.AddStudent(obj);
            return new StudentModel { Id = dataAdd.Id};
        }

        public async Task<StudentModel> DeleteStudentById(int id) {
            var studentDelete = await StudentContext.DeleteStudentById(id);
            return new StudentModel {
                Id = studentDelete.Id,
                FirstName = studentDelete.FirstName,
                LastName = studentDelete.LastName,
                Email = studentDelete.Email,
                DateOfBirth = studentDelete.DateOfBirth,
                Phone = studentDelete.Phone,
                CollegeId = studentDelete.CollegeId,
            };
        }

        public IEnumerable<StudentModel> GetAllStudents() {
            var AllStudents = StudentContext.GetAllStudents();
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

        public async Task<StudentModel> GetStudentById(int id) {
            var getStudent = await StudentContext.GetStudentById(id);
            return (new StudentModel {
                Id = getStudent.Id,
                FirstName = getStudent.FirstName,
                LastName = getStudent.LastName,
                Email = getStudent.Email,
                Phone= getStudent.Phone,
                DateOfBirth = getStudent.DateOfBirth,
            });
        }

        public async Task<StudentModel> UpdateStudent(StudentModel student) {
            var updatedData = await StudentContext.UpdateStudent(student);
            return null;
        }
    }
}
