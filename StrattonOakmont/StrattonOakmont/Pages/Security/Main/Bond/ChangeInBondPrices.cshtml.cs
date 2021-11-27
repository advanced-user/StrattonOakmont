using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class ChangeInBondPricesModel : PageModel
    {
        private readonly IBondRepository _bondRepository;
        private readonly ICompanyRepository _companyRepository;

        public ChangeInBondPricesModel(IBondRepository bondRepository, ICompanyRepository companyRepository)
        {
            _bondRepository = bondRepository;
            _companyRepository = companyRepository;
        }

        public StrattonOakmontModels.Bond Bond { get; set; }

        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int bondId)
        {
            Bond = _bondRepository.GetBond(bondId);
            Company = _companyRepository.FindCompany(companyId);
        }
    }
}
