using Microsoft.AspNetCore.Mvc;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Service;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase {
        private readonly ICollegeService icollege;

        public CollegeController(ICollegeService _icollege) {
            icollege = _icollege;
        }

        [HttpGet]
        public IActionResult GetColleges() {
            return Ok(icollege.Colleges());
        }

        [HttpPost]
        public IActionResult Add(College obj) {
            return Ok(icollege.College(obj));

        }

        [HttpGet("{id}")]
        public IActionResult GetCollegeById(int id) {
            return Ok(icollege.College(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCollege(College college, int id) {
            return Ok(icollege.College(college, id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCollegeById(int id) {
            return Ok(icollege.DeleteCollege(id));
        }
    }
}
