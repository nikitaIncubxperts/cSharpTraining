using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface {
    public interface ICollege {
        IEnumerable<CollegeModel> GetColleges();
        CollegeModel GetCollegeById(int id);
        Task<CollegeModel> AddColleges(CollegeModel college);
        CollegeModel UpdateCollege(CollegeModel college, int id);
        CollegeModel DeleteCollegeById(int id);
    }
}
