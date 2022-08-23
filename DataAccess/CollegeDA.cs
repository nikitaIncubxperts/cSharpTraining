using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess {
    public class CollegeDA : ICollegeDA{
        private readonly Student_College_DbContext DbContext;

        public CollegeDA(Student_College_DbContext _DbContext) {
            DbContext = _DbContext;
        }

        public async Task<CollegeEntity> AddColleges(CollegeEntity college) {
            var dataAdd = await DbContext.collegeData.AddAsync(college);
            DbContext.SaveChanges();
            return dataAdd.Entity;
        }

        public CollegeEntity DeleteCollegeById(int id) {
            var delCollegeData = DbContext.collegeData.FirstOrDefault(x => x.Id == id);
            if (delCollegeData != null) {
                var delStud = DbContext.collegeData.Remove(delCollegeData);
                DbContext.SaveChanges();
                return delStud.Entity;
            }
            return null;
        }

        public CollegeEntity GetCollegeById(int id) {
            var clgById = DbContext.collegeData.FirstOrDefault(x => x.Id == id);
            DbContext.SaveChanges();
            return clgById;
        }

        public IEnumerable<CollegeEntity> GetColleges() {
            return DbContext.collegeData;
        }

        public CollegeEntity UpdateCollege(CollegeEntity college, int id) {
            var collegeData = DbContext.collegeData.Where(x => x.Id == id).ToList();
            foreach (var dataUpdate in collegeData) {
                if (dataUpdate.Id == id) {
                    dataUpdate.Name = college.Name;
                    dataUpdate.University = college.University;
                    dataUpdate.District = college.District;

                    var studUpdate = DbContext.collegeData.Update(dataUpdate);
                    DbContext.SaveChanges();
                    return studUpdate.Entity;
                }
            }
            return null;
        }
    }
}
