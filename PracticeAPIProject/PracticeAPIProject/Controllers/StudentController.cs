using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeAPIProject.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {

        private List<Student> student = new List<Student>() {
                new Student {
                    ID = 1,
                    age = 34,
                    name = "Foo",
                    city = "Mumbai"
                },
                new Student {
                    ID=2,
                    age = 43,
                    name = "Bar",
                    city = "Baramati"
                }
        };

        [HttpGet("/GetStudents")]
        public IActionResult GetStudents() {
            return Ok(student);
        }

        [HttpGet("/GetStudentByID")]
        public IActionResult GetStudentByID(int id) {
            var studentByID = student.Find(x => x.ID == id);
            if (studentByID == null) {
                return BadRequest("No student found");
            }
            return Ok(studentByID);
        }

        [HttpPost("/AddStudent")]
        public IActionResult AddStudent(Student request) {
            student.Add(request);
            return Ok(student);
        }

        [HttpPut("/UpdateStudentInfo")]
        public IActionResult UpdateStudent(Student request) {
            var studentIdFetch = student.Find(x => x.ID == request.ID);
            if (studentIdFetch == null) {
                return BadRequest("No student found");
            }
            studentIdFetch.ID = request.ID;
            studentIdFetch.age = request.age;
            studentIdFetch.name = request.name;
            studentIdFetch.city = request.city;

            return Ok(student);
        }

        [HttpDelete("/DeleteStudent")]
        public IActionResult DeleteStudent(int id) { 
            var studentDeleteById = student.Find(x => x.ID == id);
            if (studentDeleteById == null) {
                return BadRequest("No data Found");
            }
            student.Remove(studentDeleteById);
            return Ok(student);
        }
    }
}

