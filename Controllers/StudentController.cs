using Microsoft.AspNetCore.Mvc;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Service;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {
        private readonly IStudentService istudent;
       
                                                                                    
        public StudentController(IStudentService _istudent) {
            istudent = _istudent;

        }
        [HttpGet]
        public IActionResult Get() {
            return Ok(istudent.Student());
        }
        [HttpPost]
        public IActionResult Add(Student obj) {
            return Ok(istudent.Student(obj));
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id) {
            return Ok(istudent.Student(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id) {
            return Ok(istudent.DeleteStudent(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Student studModelobj ,int id) {
            return Ok(istudent.Student(studModelobj ,id));
        }
    }
}
