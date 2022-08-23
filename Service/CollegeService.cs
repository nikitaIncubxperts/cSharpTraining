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

        public CollegeModel DeleteCollegeById(int id) {
            var collegeDelete = collegeContext.DeleteCollegeById(id);
            return new CollegeModel {
                Id = collegeDelete.Id
            };
        }

        public CollegeModel GetCollegeById(int id) {
            var getCollege = collegeContext.GetCollegeById(id);
            return new CollegeModel {
                Id = getCollege.Id
            };
        }

        public IEnumerable<CollegeModel> GetColleges() {
            var AllColleges = collegeContext.GetColleges();
            return (from students in AllColleges
                    select new CollegeModel {
                        Id = students.Id,
                        Address = students.Address,
                        District = students.District,
                        University = students.University,
                        Name = students.Name,
                    });
            return null;
        }

        public CollegeModel UpdateCollege(CollegeModel college, int id) {
            var obj = new CollegeEntity {
                Id = college.Id,
                Name = college.Name,
                Address = college.Address,
                District = college.District,
                University = college.University,
            };
            var updateData = collegeContext.UpdateCollege(obj, id);
            return new CollegeModel {
                Id = updateData.Id,
            };
        }
    }
}
