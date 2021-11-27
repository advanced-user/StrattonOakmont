using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.PriceChange.Bond
{
    public class EditInBondPriceChangeModel : PageModel
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPriceChangeRepository _priceChangeRepository;


        public EditInBondPriceChangeModel(ICompanyRepository companyRepository, IPriceChangeRepository priceChangeRepository)
        {
            _companyRepository = companyRepository;
            _priceChangeRepository = priceChangeRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Securities.Price—hange PriceChange { get; set; }

        public void OnGet(int companyId, int priceChangeId)
        {
            PriceChange = _priceChangeRepository.GetPrice—hange(priceChangeId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (PriceChange.Amount != 0)
            {
                PriceChange.Price = PriceChange.Volume / PriceChange.Amount;
                await _priceChangeRepository.UpdatePriceChange(PriceChange);
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
