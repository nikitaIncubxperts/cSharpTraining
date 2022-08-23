using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface {
    public interface IStudent {
        IEnumerable<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);
        Task<StudentModel> AddStudent(StudentModel student);
        StudentModel UpdateStudent(StudentModel student, int id);
        StudentModel DeleteStudentById(int id);
    }
}
