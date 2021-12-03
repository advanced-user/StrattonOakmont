using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.Company
{
    public class View : PageModel
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly ISecurityRepository _securityRepository;

        public View(ICompanyRepository companyRepository, ISecurityRepository securityRepository)
        {
            _companyRepository = companyRepository;
            _securityRepository = securityRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }
        public IEnumerable<StrattonOakmontModels.Stoсk> Stocks { get; set; }
        public IEnumerable<StrattonOakmontModels.Bond> Bonds { get; set; }

        public void OnGet(int id)
        {
            Company = _companyRepository.FindCompany(id);
            if (Company.Security != null)
            {
                Stocks = _securityRepository.GetAllStocks(Company.Security.Id);
                Bonds = _securityRepository.GetAllBonds(Company.Security.Id);
            }
        }
    }
}