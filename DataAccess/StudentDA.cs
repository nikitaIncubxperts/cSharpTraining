using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess {

    public interface IStudentDA {
        IEnumerable<StudentEntity> Student();  //get all
        StudentEntity Student(int id); //get by id
        int Student(StudentEntity student);  //add
        int Student(StudentEntity student, int id); //update
        StudentEntity DeleteStudent(int id);  //delete
    }

    public class StudentDA : IStudentDA {
        private readonly Student_College_DbContext _stud_clg_context;

        public StudentDA(Student_College_DbContext context) {
            _stud_clg_context = context;
        }

        public StudentEntity DeleteStudent(int id) {
            var delStudentData = _stud_clg_context.Students.FirstOrDefault(x => x.Id == id);
            if (delStudentData != null) {
                var delStud = _stud_clg_context.Students.Remove(delStudentData);
                _stud_clg_context.SaveChanges(); 
                return delStudentData;
            }
            return null;
        }

        public StudentEntity Student(int id) {
            var studById = _stud_clg_context.Students.FirstOrDefault(x => x.Id == id);
            _stud_clg_context.SaveChanges();
            return studById;
        }

        public int Student(StudentEntity student) {
            var dataAdd = _stud_clg_context.Students.AddAsync(student);
            _stud_clg_context.SaveChanges();
            return 1;
        }

        public int Student(StudentEntity student, int id) {
            var studentData = _stud_clg_context.Students.Where(x => x.Id == id).ToList();
            foreach (var dataUpdate in studentData) {
                if (dataUpdate.Id == id) {
                    dataUpdate.FirstName = student.FirstName;
                    dataUpdate.LastName = student.LastName;
                    dataUpdate.Email = student.Email;
                    dataUpdate.Phone = student.Phone;
                    dataUpdate.DateOfBirth = student.DateOfBirth;

                    var studUpdate = _stud_clg_context.Students.Update(dataUpdate);
                    _stud_clg_context.SaveChanges();
                }
            }
            return 1;
        }

        public IEnumerable<StudentEntity> Student() {
            return _stud_clg_context.Students;
        }
    }
}
