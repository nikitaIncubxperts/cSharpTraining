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

        //[HttpGet]
        //public async Task<ActionResult> GetAllStudents() {
        //    //return Ok(await animalRepo.GetAnimals());
        //    return Ok(await studentserviceobj.GetAllStudents());
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult> GetStudentById(int id) {
        //    return Ok(await studentserviceobj.GetStudentById(id));
        //}

        //[HttpPost]
        //public async Task<ActionResult> AddStudent(StudentEntity stud) {
        //    return Ok(await studentserviceobj.AddStudent(stud));
        //}

        //[HttpPut("{id}")]
        //public async Task<StudentEntity> UpdateAnimal(StudentEntity stud) {
        //    var updateStudent = await studentserviceobj.UpdateStudent(stud);
        //    return updateStudent;
        //}

        //[HttpDelete("{id}")]
        //public async Task<StudentEntity> DeleteAnimal(int id) {
        //    return await studentserviceobj.DeleteStudentById(id);
        //}
    }
}
