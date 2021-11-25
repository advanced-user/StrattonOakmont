using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
        Task<Category> ChangeCategoryAsync(Category addCategory);
        Task<Category> FindCategoryAsync(int id);
    }
}
