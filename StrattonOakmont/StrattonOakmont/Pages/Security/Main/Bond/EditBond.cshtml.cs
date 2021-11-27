using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class EditBondModel : PageModel
    {
        private readonly IBondRepository _stockRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly AppDBContext _appDBContext;

        public EditBondModel(AppDBContext appDBContext, IBondRepository stockRepository,
                              ICompanyRepository companyRepository, IPriceChangeRepository priceChangeRepository)
        {
            _appDBContext = appDBContext;
            _stockRepository = stockRepository;
            _companyRepository = companyRepository;
            _priceChangeRepository = priceChangeRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Bond Bond { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int bondId)
        {
            Bond = _stockRepository.GetBond(bondId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPost()
        {
            var bond = await _stockRepository.GetBondAsync(Bond.Id);
            if (Bond != null && bond != null && Bond.Amount != 0)
            {
                bond.Percent = Bond.Percent;
                bond.FinalTime = Bond.FinalTime;
                bond.Amount = Bond.Amount;
                bond.Volume = Bond.Volume;
                bond.Price = Bond.Volume / Bond.Amount;

                var priceChage = await _priceChangeRepository.GetLatestBondPriceChageAsync(bond.Id);
                priceChage.Price = bond.Price;

                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
