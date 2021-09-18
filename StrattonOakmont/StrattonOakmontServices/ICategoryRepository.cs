using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
