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
       
        [BindProperty]
        public List<StrattonOakmontModels.Company> Companies { get; set; }  
        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }

        [BindProperty]
        public IEnumerable<Category> AllCategories { get; set; }

        [BindProperty]
        public List<string> CheckedCategories { get; set; }
        
        [BindProperty]
        public int Sort { get; set; }
        

        public void OnGet()
        {
            Companies = _dbCompany.GetAllCompanies.ToList();
            AllCategories = _dbCategory.GetAllCategories;
            CheckedCategories = new List<string>();
        }

        public void OnPostFilter(List<string> categories)
        {
            Companies = _dbCompany.FilterCompanies(categories);
            AllCategories = _dbCategory.GetAllCategories;
            CheckedCategories = categories;
        }

        public void OnPostSearch(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Companies = _dbCompany.GetAllCompanies.ToList();
            }
            else
            {
                Companies = _dbCompany.GetCompaniesByName(name).ToList();
            }
            Securities = _dbSecurity.GetAllSecurities;
        }

        public void OnPostSort(List<string> categories)
        {
            if (Sort == 1)
            {
                Companies = _dbCompany.FilterCompanies(categories).OrderByDescending(x => x.Name).ToList();
                Sort = -1;
            }
            else
            {
                Sort = 1;
                Companies = _dbCompany.FilterCompanies(categories).OrderBy(x => x.Name).ToList();
            }
            AllCategories = _dbCategory.GetAllCategories;
            CheckedCategories = categories;
        }

        [BindProperty]
        public int More { get; set; }

        [BindProperty]
        public int Less { get; set; }

        public void OnPostFilterPrice()
        {
            Companies = _dbCompany.FilterPrice(More, Less);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _dbCompany.DeleteCompanyAsync(id);

            return RedirectToPage("Company");
        }
    }
}
