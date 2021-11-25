using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql
{
	public class SqlCategoryRepository : ICategoryRepository
	{
		private readonly AppDBContext _context;

		public SqlCategoryRepository(AppDBContext context)
		{
			_context = context;
		}

		public IEnumerable<Category> GetAllCategories
		{
			get
			{
				return _context.Categories;
			}
		}

		public async Task<Category> AddCategoryAsync(Category addCategory)
		{
			await _context.Categories.AddAsync(addCategory);
			await _context.SaveChangesAsync();

			return addCategory;
		}

        public Task<Category> ChangeCategoryAsync(Category addCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> FindCategoryAsync(int id)
        {
			return await _context.Categories.FindAsync(id);
		}
	}
}
