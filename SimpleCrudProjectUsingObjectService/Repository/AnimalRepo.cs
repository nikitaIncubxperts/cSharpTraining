using SimpleCrudProjectUsingObjectService.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCrudProjectUsingObjectService.Repository {

    public interface AnimalRepo {
        Task<IEnumerable<AnimalModel>> GetAnimals();
        Task<AnimalModel> GetAnimalById(int age);
        Task <AnimalModel> AddAnimal(AnimalModel animal);
        Task<AnimalModel> UpdateAnimal(AnimalModel animal);
        Task<AnimalModel> DeleteAnimal(int age);
    }
}
