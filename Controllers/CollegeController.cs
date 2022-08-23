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
            icollege = _icollege;
        }

        [HttpGet]
        public IActionResult GetColleges() {
            return Ok(icollege.GetColleges());
        }

        [HttpPost]
        public IActionResult Add(CollegeModel obj) {
            return Ok(icollege.AddColleges(obj));

        }

        [HttpGet("{id}")]
        public IActionResult GetCollegeById(int id) {
            return Ok(icollege.GetCollegeById(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCollege(CollegeModel college, int id) {
            return Ok(icollege.UpdateCollege(college, id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCollegeById(int id) {
            return Ok(icollege.DeleteCollegeById(id));
        }
    }
}
