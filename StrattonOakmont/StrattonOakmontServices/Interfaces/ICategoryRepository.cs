using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
        Category AddCategory(Category addCategory);
    }
}
