using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final_Project.Data;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;

        private readonly IStudentsContextDAO _context;

        public StudentsController(ILogger<StudentsController> logger, IStudentsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.GetAllStudent());
        }

        [HttpGet("id")]

        public IActionResult Get(int id)
        {
            var student = _context.GetStudentById(id);
            if (student == null)
                return NotFound(id);

            return Ok(student);
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var result = _context.RemoveStudentById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0 )
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
         }

        [HttpPut]
        public IActionResult Put(Students student)
        {
            var result = _context.UpdateStudent(student);

            if (result == null)
                return NotFound(student.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

        [HttpPost]

        public IActionResult Post(Students students)
        {
           var result =  _context.Add(students);

            if (result == null)
                return StatusCode(500, "Student already exists");

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }
    }
}
