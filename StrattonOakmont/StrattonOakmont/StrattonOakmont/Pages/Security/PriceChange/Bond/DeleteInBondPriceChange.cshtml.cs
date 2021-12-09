using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.PriceChange.Bond
{
    public class DeleteInBondPriceChangeModel : PageModel
    {
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly ICompanyRepository _companyRepository;

        public DeleteInBondPriceChangeModel(IPriceChangeRepository priceChangeRepository, ICompanyRepository companyRepository)
        {
            _priceChangeRepository = priceChangeRepository;
            _companyRepository = companyRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Securities.Price—hange PriceChange { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int priceChangeId)
        {
            PriceChange = _priceChangeRepository.GetPrice—hange(priceChangeId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _priceChangeRepository.DeletePrice—hangeAsync(PriceChange.Id);

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
