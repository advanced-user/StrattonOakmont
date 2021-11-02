using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

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

		public Category AddCategory(Category addCategory)
		{
			_context.Categories.Add(addCategory);
			_context.SaveChanges();

			return addCategory;
		}
	}
}
