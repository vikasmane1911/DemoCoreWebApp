using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Services;
using DemoCoreWebApp.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Web.Factories
{
    public class CategoryModelFactory : ICategoryModelFactory
    {
        #region Fields

        private readonly ICategoryService _categoryService;

        #endregion

        #region Ctor

        public CategoryModelFactory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #endregion

        #region Public Methods

        public async Task AddCategory(CategoryModel categoryModel)
        {
            Category category = new Category
            {
                Id = categoryModel.Id,
                Name = categoryModel.Name,
                Description = categoryModel.Description
            };

            await _categoryService.InsertCategory(category);
        }

        public async Task<IList<CategoryModel>> PrepareCategoryModel()
        {
            IList<CategoryModel> categoryModels = new List<CategoryModel>();
            IList<Category> categories = await _categoryService.GetAllCategories();

            foreach (var category in categories)
            {
                CategoryModel categoryModel = new CategoryModel
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                };

                categoryModels.Add(categoryModel);
            }

            return categoryModels;
        }

        #endregion
    }
}
