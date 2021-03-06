using System;
using System.Collections.Generic;
using ZPOS.UI.Entities;
using ZPOS.UI.Interfaces;

namespace ZPOS.UI.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategory _categoryRepository;

        public CategoryServices(ICategory categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
