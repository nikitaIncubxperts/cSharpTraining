using Microsoft.AspNetCore.Mvc;
using SimpleCrudProjectUsingObjectService.Model;
using SimpleCrudProjectUsingObjectService.Repository;
using SimpleCrudProjectUsingObjectService.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrudProjectUsingObjectService.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController :ControllerBase {
        private readonly AnimalRepo animalRepo;

        public AnimalController(AnimalRepo _animalRepo) {
            animalRepo = _animalRepo;
            //AnimalService animObject = new AnimalService();
        }

        [HttpGet]
        public async Task<ActionResult> GetAnimals() {
            return Ok(await animalRepo.GetAnimals());
        }

        [HttpGet("{age}")]
        public async Task<ActionResult> GetAnimalById(int age) {
            return Ok(await animalRepo.GetAnimalById(age));
        }

        [HttpPost]
        public async Task<ActionResult> AddAnimal(AnimalModel anim) {
            return Ok(await animalRepo.AddAnimal(anim));
        }

        [HttpPut("{age}")]
        public async Task<AnimalModel> UpdateAnimal(AnimalModel anim) {
            var updateAnimal = await animalRepo.UpdateAnimal(anim);
            return updateAnimal;
        }

        [HttpDelete("{age}")]
        public async Task<AnimalModel> DeleteAnimal(int age) {
            return await animalRepo.DeleteAnimal(age);
        }
    }
}
