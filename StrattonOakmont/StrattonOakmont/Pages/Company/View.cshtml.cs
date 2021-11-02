using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Company
{
    public class View : PageModel
    {
        
        private readonly ICompanyRepository _dbCompany;
        
        public View(ICompanyRepository dbCompany)
        {
            _dbCompany = dbCompany;
        }
        
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int id)
        {
           Company = _dbCompany.FindCompany(id);
        }
    }
}