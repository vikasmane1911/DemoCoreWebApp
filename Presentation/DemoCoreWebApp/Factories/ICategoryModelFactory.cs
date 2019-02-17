using DemoCoreWebApp.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Web.Factories
{
    public interface ICategoryModelFactory
    {
        Task<IList<CategoryModel>> PrepareCategoryModel();

        Task AddCategory(CategoryModel categoryModel);
    }
}
