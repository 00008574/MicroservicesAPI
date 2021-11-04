using CW1_MicroservicesAPI_8574.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW1_MicroservicesAPI_8574.Repository
{
    public interface ICategoryRepository
    {
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetCategories();
    }
}
