using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface {
    public interface ICollege {
        Task<IEnumerable<CollegeModel>> GetColleges();
        Task<CollegeModel> GetCollegeById(int id);
        Task<CollegeModel> AddColleges(CollegeModel college);
        Task<CollegeModel> UpdateCollege(CollegeModel college);
        Task<CollegeModel> DeleteCollegeById(int id);
    }
}
