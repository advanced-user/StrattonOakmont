using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security
{
    public class TypeOfSecurityModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly ICategoryRepository _dbCategory; 

        public TypeOfSecurityModel(ICompanyRepository dbCompany, ICategoryRepository categoryRepository)
        {
            _dbCompany = dbCompany;
            _dbCategory = categoryRepository;
        }

        [BindProperty]
        public List<StrattonOakmontModels.Category> Categories { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }   
        
        public void OnGet(int id)
        {
            Company = _dbCompany.FindCompany(id);
            Categories = _dbCategory.GetAllCategories.ToList();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var category = await _dbCategory.FindCategoryAsync(id);

            if (category != null)
            {
                switch (category.CategoryName)
                {
                    case "Stonk":
                        return RedirectToPage("Main/Stonk/AddStonk", new { companyId = Company.Id, categoryId = category.Id });
                    case "Abligation":
                        return RedirectToPage("Main/Abligation/AddAbligation", new { companyId = Company.Id, categoryId = category.Id });
                }
            }

            return Page();
        }
    }
}
