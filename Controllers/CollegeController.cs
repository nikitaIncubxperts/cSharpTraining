using Microsoft.AspNetCore.Mvc;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Service;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase {
        private readonly ICollege icollege;

        public CollegeController(ICollege _icollege) {
            icollege = icollege;
        }

        [HttpGet]
        public IActionResult GetColleges() {
            return Ok(icollege.GetColleges());
        }

        [HttpPost]
        public IActionResult Add(CollegeModel obj) {
            return Ok(icollege.AddColleges(obj));

        }

        //[HttpGet]
        //public async Task<ActionResult> GetColleges() {
        //    //return Ok(await animalRepo.GetAnimals());
        //    return Ok(await collegeserviceobj.GetColleges());
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult> GetCollegeById(int id) {
        //    return Ok(await collegeserviceobj.GetCollegeById(id));
        //}

        //[HttpPost]
        //public async Task<ActionResult> AddColleges(CollegeEntity clg) {
        //    return Ok(await collegeserviceobj.AddColleges(clg));
        //}

        //[HttpPut("{id}")]
        //public async Task<CollegeEntity> UpdateCollege(CollegeEntity clg) {
        //    var updateCollege = await collegeserviceobj.UpdateCollege(clg);
        //    return updateCollege;
        //}

        //[HttpDelete("{id}")]
        //public async Task<CollegeEntity> DeleteCollegeById(int id) {
        //    return await collegeserviceobj.DeleteCollegeById(id);
        //}
    }
}
