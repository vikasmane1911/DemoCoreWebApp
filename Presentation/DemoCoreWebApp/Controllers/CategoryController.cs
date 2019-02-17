using DemoCoreWebApp.Web.Factories;
using DemoCoreWebApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        #region Fields

        private readonly ICategoryModelFactory _categoryModelFactory;

        #endregion

        #region Ctor

        public CategoryController(ICategoryModelFactory categoryModelFactory)
        {
            _categoryModelFactory = categoryModelFactory;
        }

        #endregion

        #region Action Methods

        public async Task<IActionResult> Index()
        {
            var categoryModels = await _categoryModelFactory.PrepareCategoryModel();
            return View(categoryModels);
        }

        public async Task<IActionResult> Create(CategoryModel category)
        {
            await _categoryModelFactory.AddCategory(category);
            return View();
        }

        #endregion
    }
}