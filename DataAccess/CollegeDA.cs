using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess {

    public interface ICollegeDA {
        IEnumerable<CollegeEntity> Colleges(); //get all
        CollegeEntity College(int id); //get by id
        int College(CollegeEntity college);   //add
        int College(CollegeEntity college, int id); //update
        CollegeEntity DeleteCollege(int id); //delete
    }

    public class CollegeDA : ICollegeDA{
        private readonly Student_College_DbContext DbContext;

        public CollegeDA(Student_College_DbContext _DbContext) {
            DbContext = _DbContext;
        }

        public CollegeEntity College(int id) {
            var clgById = DbContext.Colleges.FirstOrDefault(x => x.Id == id);
            DbContext.SaveChanges();
            return clgById;
        }

        public int College(CollegeEntity college) {
            var dataAdd = DbContext.Colleges.AddAsync(college);
            DbContext.SaveChanges();
            return 1;
        }

        public int College(CollegeEntity college, int id) {
            var collegeData = DbContext.Colleges.Where(x => x.Id == id).ToList();
            foreach (var dataUpdate in collegeData) {
                if (dataUpdate.Id == id) {
                    dataUpdate.Name = college.Name;
                    dataUpdate.University = college.University;
                    dataUpdate.District = college.District;

                    var studUpdate = DbContext.Colleges.Update(dataUpdate);
                    DbContext.SaveChanges();
                }
            }
            return 1;
        }

        public IEnumerable<CollegeEntity> Colleges() {
            return DbContext.Colleges;
        }

        public CollegeEntity DeleteCollege(int id) {
            var delCollegeData = DbContext.Colleges.FirstOrDefault(x => x.Id == id);
            if (delCollegeData != null) {
                var delCollege = DbContext.Colleges.Remove(delCollegeData);
                DbContext.SaveChanges();
                return delCollegeData;
            }
            return null;
        }
    }
}
