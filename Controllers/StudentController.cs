using Microsoft.AspNetCore.Mvc;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Entites;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Interface;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Model;
using RestfulCRUD_APIs_CodingStandard_Validation_DI.Service;
using System.Threading.Tasks;

namespace RestfulCRUD_APIs_CodingStandard_Validation_DI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {
        private readonly IStudent istudent;
       
                                                                                    
        public StudentController(IStudent _istudent) {
            istudent = _istudent;

        }
        [HttpGet]
        public IActionResult Get() {
            return Ok(istudent.GetAllStudents());
        }
        [HttpPost]
        public IActionResult Add(StudentModel obj) {
            return Ok(istudent.AddStudent(obj));
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id) {
            return Ok(istudent.GetStudentById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id) {
            return Ok(istudent.DeleteStudentById(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(StudentModel studModelobj ,int id) {
            return Ok(istudent.UpdateStudent(studModelobj ,id));
        }
    }
}
