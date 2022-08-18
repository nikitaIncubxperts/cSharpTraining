using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCrudProjectUsingObjectService.Model;
using SimpleCrudProjectUsingObjectService.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrudProjectUsingObjectService.Service {

    public class AnimalService : AnimalRepo {
        private readonly AnimalContext _AnimalContext;

        public AnimalService(AnimalContext animalContext) {
            _AnimalContext = animalContext;
        }

        public async Task<AnimalModel> AddAnimal(AnimalModel animal) {
           await _AnimalContext.animals.AddAsync(animal);
            _AnimalContext.SaveChanges();
            return animal;
        }

        public async Task<AnimalModel> DeleteAnimal(int age) {
            var anim = await _AnimalContext.animals.Where(x => x.age == age).FirstOrDefaultAsync();
            if (anim != null) {
                _AnimalContext.animals.Remove(anim);
                await _AnimalContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<AnimalModel> GetAnimalById(int age) {
            return await _AnimalContext.animals.FirstOrDefaultAsync(a => a.age == age);
        }

        public async Task<IEnumerable<AnimalModel>> GetAnimals() {
            return await _AnimalContext.animals.ToListAsync();
        }

        public async Task<AnimalModel> UpdateAnimal(AnimalModel animal) {
            var result = await _AnimalContext.animals.FirstOrDefaultAsync(a => a.age == animal.age);
            if (result != null) {
                result.name = animal.name;
                result.color = animal.color;
                await _AnimalContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //public AnimalService(AnimalContext animalContext) {
        //    _AnimalContext = animalContext;
        //}

        //public void AddAnimal([FromBody] AnimalModel animal) {
        //    _AnimalContext.animals.Add(animal);
        //    _AnimalContext.SaveChanges();
        //}

        //public void DeleteAnimal(int age) {
        //    var anim = _AnimalContext.animals.FirstOrDefault(x => x.age == age);
        //    if (anim != null) {
        //        _AnimalContext.animals.Remove(anim);
        //        _AnimalContext.SaveChanges();
        //    }
        //}

        //public Task<AnimalModel> GetAnimalById(int id) {
        //    throw new System.NotImplementedException();
        //}

        //public IEnumerable<AnimalModel> GetAnimals() {
        //    return _AnimalContext.animals;
        //}        
    }
}
