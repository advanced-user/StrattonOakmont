using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels;
using StrattonOakmontServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.AdminArea
{
    public class CompanyModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly ISecurityRepository _dbSecurity;
        private readonly ICategoryRepository _dbCategory;

        public CompanyModel(ICompanyRepository dbCompany, ISecurityRepository dbSecurity, ICategoryRepository dbCategory)
        {
            _dbCompany = dbCompany;
            _dbSecurity = dbSecurity;
            _dbCategory = dbCategory;
        }
       
       
        public IEnumerable<StrattonOakmontModels.Company> Companies { get; set; }  
        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }

        [BindProperty]
        public IEnumerable<Category> AllCategories { get; set; }

        [BindProperty]
        public List<string> CheckedCategories { get; set; }
        

        public void OnGet()
        {
            Companies = _dbCompany.GetAllCompanies;
            AllCategories = _dbCategory.GetAllCategories;
            CheckedCategories = new List<string>();
        }

        public void OnPostFilter(List<string> categories)
        {
            Companies = _dbCompany.FilterCompanies(categories);
            CheckedCategories = categories;
        }

        public void OnPostSearch(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Companies = _dbCompany.GetAllCompanies;
            }
            else
            {
                Companies = _dbCompany.GetCompaniesByName(name);
            }
            Securities = _dbSecurity.GetAllSecurities;
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _dbCompany.DeleteCompanyAsync(id);

            return RedirectToPage("Company");
        }
    }
}
