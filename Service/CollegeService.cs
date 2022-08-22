using Microsoft.EntityFrameworkCore;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Data;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Service {
    public class CollegeService : ICollege {
       private readonly ICollegeDA collegeContext;
        public CollegeService(ICollegeDA _collegeContext) {
            collegeContext = _collegeContext;
        }

        public async Task<CollegeModel> AddColleges(CollegeModel college) {
            var collegeObj = new CollegeEntity {

                Id = college.Id,
                Address = college.Address,
                District = college.District,
                University = college.University,
                Name = college.Name,
            };

            var dataAdd = await collegeContext.AddColleges(collegeObj);
            return new CollegeModel { Id = dataAdd.Id };
        }

        public async Task<CollegeModel> DeleteCollegeById(int id) {
            return null;
        }

        public async Task<CollegeModel> GetCollegeById(int id) {
            return null;
        }

        public Task<IEnumerable<CollegeModel>> GetColleges() {
            return null;
        }

        public async Task<CollegeModel> UpdateCollege(CollegeModel college) {
            return null;
        }

        //public async Task<CollegeModel> AddColleges(CollegeModel college) {
        //    await _collegeContext.college.AddAsync(college);
        //    _collegeContext.SaveChanges();
        //    return college;
        //}

        //public async Task<CollegeModel> DeleteCollegeById(int id) {
        //    var collegeData = await _collegeContext.college.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    if (collegeData != null) {
        //        _collegeContext.college.Remove(collegeData);
        //        await _collegeContext.SaveChangesAsync();
        //    }
        //    return null;
        //}

        //public async Task<CollegeModel> GetCollegeById(int id) {
        //    return await _collegeContext.college.FirstOrDefaultAsync(a => a.Id == id);
        //}

        //public async Task<IEnumerable<CollegeModel>> GetColleges() {
        //    return await _collegeContext.college.ToListAsync();
        //}

        //public async Task<CollegeModel> UpdateCollege(CollegeModel college) {
        //    var result = await _collegeContext.college.FirstOrDefaultAsync(a => a.Id == college.Id);
        //    if (result != null) {
        //        result.Name = college.Name;
        //        result.Address = college.Address;
        //        result.District = college.District;
        //        result.University = college?.University;
        //        await _collegeContext.SaveChangesAsync();
        //        return result;
        //    }
        //    return null;
        //}
    }
}
