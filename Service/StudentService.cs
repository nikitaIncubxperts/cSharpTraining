using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Linq;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Service {

    public interface IStudentService {
        IEnumerable<Student> Student();  //get all
        Student Student(int id); //get by id
        int Student(Student student);  //add
        int Student(Student student, int id); //update
        bool DeleteStudent(int id);  //delete
    }

    public class StudentService : IStudentService {

        private readonly IStudentDA studentContext;
        public StudentService(IStudentDA _StudentContext) {
            studentContext = _StudentContext;
        }

        public bool DeleteStudent(int id) {
            var studentDelete = studentContext.DeleteStudent(id);
            return true;
        }

        public Student Student(int id) {
            var getStudent = studentContext.Student(id);
            return new Student {
                Id = getStudent.Id,
                FirstName = getStudent.FirstName,
                LastName = getStudent.LastName,
                Email = getStudent.Email,
                Phone = getStudent.Phone,
                DateOfBirth = getStudent.DateOfBirth,
                CollegeId = getStudent.CollegeId
            };
        }

        public int Student(Student student) {
            var obj = new StudentEntity {

                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth,
                CollegeId = student.CollegeId,
                Phone = student.Phone,
            };
            var dataAdd = studentContext.Student(obj);
            return 1;
        }

        public int Student(Student student, int id) {
            var obj = new StudentEntity {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                Phone = student.Phone,
                DateOfBirth = student.DateOfBirth,
            };
            var updateData = studentContext.Student(obj, id);
            return 1;
        }

        public IEnumerable<Student> Student() {
            var AllStudents = studentContext.Student();
            return (from students in AllStudents
                    select new Student {
                        Id = students.Id,
                        FirstName = students.FirstName,
                        LastName = students.LastName,
                        Email = students.Email,
                        Phone = students.Phone,
                        DateOfBirth = students.DateOfBirth,
                    });
        }
    }
}
