using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess {
    public interface ICollegeDA {
        IEnumerable<CollegeEntity> GetColleges();
        CollegeEntity GetCollegeById(int id);
        Task<CollegeEntity> AddColleges(CollegeEntity college);
        CollegeEntity UpdateCollege(CollegeEntity college, int id);
        CollegeEntity DeleteCollegeById(int id);
    }
}
