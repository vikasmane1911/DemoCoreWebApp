using DemoCoreWebApp.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Services
{
    public interface ICategoryService
    {
        Task InsertCategory(Category category);
        Task UpdateCategory(Category category);
        Task<IList<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int? id);
        bool CategoryExists(int id);
    }
}
