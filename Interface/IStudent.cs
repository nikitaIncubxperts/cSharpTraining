using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface {
    public interface IStudent {
        IEnumerable<StudentModel> GetAllStudents();
        Task<StudentModel> GetStudentById(int id);
        Task<StudentModel> AddStudent(StudentModel student);
        Task<StudentModel> UpdateStudent(StudentModel student);
        Task<StudentModel> DeleteStudentById(int id);
    }
}
