using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.IDataAccess {
    public interface ICollegeDA {
        Task<IEnumerable<CollegeEntity>> GetColleges();
        Task<CollegeEntity> GetCollegeById(int id);
        Task<CollegeEntity> AddColleges(CollegeEntity college);
        Task<CollegeEntity> UpdateCollege(CollegeEntity college);
        Task<CollegeEntity> DeleteCollegeById(int id);
    }
}
