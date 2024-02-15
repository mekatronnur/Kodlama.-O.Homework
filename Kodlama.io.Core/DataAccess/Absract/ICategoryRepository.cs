using Kodlama.io.Core.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Core.DataAccess.Absract
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int categoryId);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}
