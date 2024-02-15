using Kodlama.io.Core.DataAccess.Absract;
using Kodlama.io.Core.Tables;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // POST: api/Category
        [HttpPost]
        public IActionResult PostCategory(Category category)
        {
            _categoryRepository.CreateCategory(category);

            return CreatedAtAction(nameof(GetCategory), new { id = category.CategoryId }, category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _categoryRepository.UpdateCategory(category);

            return NoContent();
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);

            return NoContent();
        }

    }
}
