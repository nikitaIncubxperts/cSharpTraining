using RestfulCRUD_APIs_CodingStandard_Validation_DI.DataAccess;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Service {

    public interface ICollegeService {
        IEnumerable<College> Colleges(); //get all
        College College(int id); //get by id
        int College(College college);   //add
        int College(College college, int id); //update
        bool DeleteCollege(int id); //delete
    }

    public class CollegeService : ICollegeService {
        private readonly ICollegeDA collegeContext;
        public CollegeService(ICollegeDA _collegeContext) {
            collegeContext = _collegeContext;
        }

        public College College(int id) {
            var getCollege = collegeContext.College(id);
            return new College {
                Id = getCollege.Id,
                Name = getCollege.Name,
                University = getCollege.University,
                Address = getCollege.Address,
                District = getCollege.District,
            };
        }

        public int College(College college) {
            var collegeObj = new CollegeEntity {
                Id = college.Id,
                Address = college.Address,
                District = college.District,
                University = college.University,
                Name = college.Name,
            };
            var dataAdd = collegeContext.College(collegeObj);
            return 1;
        }

        public int College(College college, int id) {
            var obj = new CollegeEntity {
                Id = college.Id,
                Name = college.Name,
                Address = college.Address,
                District = college.District,
                University = college.University,
            };
            var updateData = collegeContext.College(obj, id);
            return 1;
        }

        public IEnumerable<College> Colleges() {
            var AllColleges = collegeContext.Colleges();
            return (from students in AllColleges
                    select new College {
                        Id = students.Id,
                        Address = students.Address,
                        District = students.District,
                        University = students.University,
                        Name = students.Name,
                    });
        }

        public bool DeleteCollege(int id) {
            var deleteData =  collegeContext.DeleteCollege(id);
            return true;
        }
    }
}
