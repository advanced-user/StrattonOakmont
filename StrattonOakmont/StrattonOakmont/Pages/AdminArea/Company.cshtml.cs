using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.AdminArea
{
    public class CompanyModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;

        public CompanyModel(ICompanyRepository dbCompany)
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
