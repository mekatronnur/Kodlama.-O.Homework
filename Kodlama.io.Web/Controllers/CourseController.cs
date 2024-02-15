using Kodlama.io.Core.DataAccess.Absract;
using Kodlama.io.Core.Tables;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseRepository.GetCourseById(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // POST: api/Category
        [HttpPost]
        public IActionResult PostCourse(Course course)
        {
            _courseRepository.CreateCourse(course);

            return CreatedAtAction(nameof(GetCourse), new { id = course.CourseId}, course);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult PutCourse(int id, Course course)
        {
            if (id !=course.CourseId)
            {
                return BadRequest();
            }

            _courseRepository.UpdateCourse(course);

            return NoContent();
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _courseRepository.DeleteCourse(id);

            return NoContent();
        }

    }
}
