using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Company
{
    public class Index : PageModel
    {
        private readonly ICompanyRepository _dbCompany;

        public Index(ICompanyRepository dbCompany)
        {
            _dbCompany = dbCompany;
        }

        public IEnumerable<StrattonOakmontModels.Company> Companies { get; set; }

        public void OnGet()
        {
            Companies = _dbCompany.GetAllCompanies;
        }

    }
}