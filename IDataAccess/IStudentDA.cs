using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess {
    public interface IStudentDA {
        IEnumerable<StudentEntity> GetAllStudents();
        StudentEntity GetStudentById(int id);
        Task<StudentEntity> AddStudent(StudentEntity student);
        StudentEntity UpdateStudent(StudentEntity student, int id);
        StudentEntity DeleteStudentById(int id);
    }
}
