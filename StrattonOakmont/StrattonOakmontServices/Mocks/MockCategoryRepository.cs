using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Stock", Id = 1},
                    new Category{CategoryName = "Abligation", Id = 2}
                };
            }
        }

		public Category AddCategory()
		{
			throw new NotImplementedException();
		}

		public Category AddCategory(Category addCategory)
		{
			throw new NotImplementedException();
		}
	}
}
