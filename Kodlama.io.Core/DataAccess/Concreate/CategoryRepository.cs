using Kodlama.io.Core.Context;
using Kodlama.io.Core.DataAccess.Absract;
using Kodlama.io.Core.Tables;


namespace Kodlama.io.Core.DataAccess.Concreate
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CourseContext _courseContext;

        public CategoryRepository(CourseContext courseContext)
        {
            _courseContext = courseContext;
        }
        public void CreateCategory(Category category)
        {
            _courseContext.Categories.Add(category);
            _courseContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category= _courseContext.Categories.Find(categoryId);
            if (category != null)
            {
                _courseContext.Categories.Remove(category);
                _courseContext.SaveChanges();
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            return _courseContext.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            _courseContext.Categories.Update(category);
            _courseContext.SaveChanges();
        }
    }
}
