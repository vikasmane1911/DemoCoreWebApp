using DemoCoreWebApp.Services;
using DemoCoreWebApp.Web.Factories;
using DemoCoreWebApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        #region Fields

        private readonly ICategoryModelFactory _categoryModelFactory;
        private readonly ICategoryService _categoryService;

        #endregion

        #region Ctor

        public CategoryController(ICategoryModelFactory categoryModelFactory,
                                  ICategoryService categoryService)
        {
            _categoryModelFactory = categoryModelFactory;
            _categoryService = categoryService;
        }

        #endregion

        #region Action Methods

        public async Task<IActionResult> Index()
        {
            var categoryModels = await _categoryModelFactory.PrepareCategoryModel();
            return View(categoryModels);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                await _categoryModelFactory.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryModel category = await _categoryModelFactory.PrepareCategoryModelById(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int Id, CategoryModel categoryModel)
        {
            if (Id != categoryModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryModelFactory.UpdateCategory(categoryModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(categoryModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(categoryModel);
        }

        private bool CategoryExists(int Id)
        {
            return _categoryService.CategoryExists(Id);
        }

        #endregion
    }
}