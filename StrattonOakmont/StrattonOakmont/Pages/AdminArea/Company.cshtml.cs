using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _dbCompany.DeleteCompanyAsync(id);

            return RedirectToPage("Company");
        }
    }
}
