using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess {
    public class CollegeDA : ICollegeDA{
        private readonly Student_College_DbContext DbContext;

        public CollegeDA(Student_College_DbContext _DbContext) {
            DbContext = _DbContext;
        }

        public Task<CollegeEntity> AddColleges(CollegeEntity college) {
            throw new System.NotImplementedException();
        }

        public async Task<StudentEntity> AddStudent(StudentEntity student) {
            var data = await DbContext.studentData.AddAsync(student);
            DbContext.SaveChanges();
            return data.Entity;
        }

        public Task<CollegeEntity> DeleteCollegeById(int id) {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<StudentEntity> DeleteStudentById(int id) {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<StudentModel>> GetAllStudents() {
            throw new System.NotImplementedException();
        }

        public Task<CollegeEntity> GetCollegeById(int id) {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CollegeEntity>> GetColleges() {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<StudentModel> GetStudentById(int id) {
            throw new System.NotImplementedException();
        }

        public Task<CollegeEntity> UpdateCollege(CollegeEntity college) {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<StudentModel> UpdateStudent(StudentModel student) {
            throw new System.NotImplementedException();
        }

        //    public async Task<StudentEntity> AddStudent(StudentEntity studObj) {
        //        var data = await _context.StudentTable.AddAsync(studObj);
        //        _context.SaveChanges();
        //        return data.Entity;
        //    }

        //    public StudentEntity DeleteStudent(int id) {
        //        var result = _context.StudentTable.Where(a => a.Id == id).FirstOrDefault();
        //        if (result != null) {
        //            _context.StudentTable.Remove(result);
        //            _context.SaveChanges();
        //            return result;
        //        }
        //        return null;
        //    }

        //    public IEnumerable<StudentEntity> GetAll() {
        //        return _context.StudentTable.ToList();
        //    }

        //    public StudentEntity GetById(int id) {
        //        return _context.StudentTable.FirstOrDefault(a => a.Id == id);
        //    }

        //    public StudentEntity UpdateStudent(StudentEntity updateStud, int id) {
        //        var update = _context.StudentTable.Where(a => a.Id == id).ToList();
        //        foreach (var data in update) {
        //            if (data.Id == id) {
        //                data.FirstName = updateStud.FirstName;
        //                data.LastName = updateStud.LastName;
        //                data.Email = updateStud.Email;
        //                data.Phone = updateStud.Phone;
        //                data.DateOfBirth = updateStud.DateOfBirth;
        //                data.CollegeId = updateStud.CollegeId;

        //                var updatedData = _context.StudentTable.Update(data);
        //                _context.SaveChanges();
        //                return updatedData.Entity;
        //            }
        //        }
        //        return updateStud;
        //    }
        //}

    }
}
