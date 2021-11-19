using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class AddModel : PageModel
    {
        private readonly ICategoryRepository _dbCategory;

        public AddModel(ICategoryRepository dbCategory)
		{
            _dbCategory = dbCategory;
        }

        public void OnGet()
        {
        }
        
        [BindProperty]
        public StrattonOakmontModels.Category Category { get; set; }

        public async Task<IActionResult> OnPost()
        {
            await _dbCategory.AddCategoryAsync(Category);
            
            return RedirectToPage("Security");
        }
    }
}
