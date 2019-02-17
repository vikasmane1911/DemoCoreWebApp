using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreWebApp.Services
{
    public class CategoryService : ICategoryService
    {
        #region Fields

        private readonly IRepository<Category> _categoryRepository;

        #endregion

        #region Constructor

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        #endregion

        #region Public Methods

        public async Task InsertCategory(Category category)
        {
            await _categoryRepository.CreateAsync(category);
        }

        public async Task<IList<Category>> GetAllCategories()
        {
            IQueryable<Category> categories = _categoryRepository.GetAll();
            return await categories.ToListAsync();
        }

        #endregion
    }
}
