using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System;
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

        [BindProperty]
        public StrattonOakmontModels.Securities.Price—hange Price—hange { get; set; }

        public void OnGet(int companyId, int bondId)
        {
            Bond = _stockRepository.GetBond(bondId);
            Company = _companyRepository.FindCompany(companyId);

            if (Bond.Price—hanges != null && Bond.Price—hanges.Count != 0)
            {
                Price—hange = _priceChangeRepository.GetLatestBondPriceChage(bondId);
            }
            else
            {
                Price—hange = new StrattonOakmontModels.Securities.Price—hange
                {
                    Price = 0,
                    Amount = 0,
                    Volume = 0
                };
            }
        }

        public async Task<IActionResult> OnPost()
        {
            var bond = await _stockRepository.GetBondAsync(Bond.Id);
            if (Bond != null && bond != null && Price—hange.Amount != 0)
            {
                bond.Percent = Bond.Percent;
                bond.FinalTime = Bond.FinalTime;

                var priceChange = new StrattonOakmontModels.Securities.Price—hange()
                {
                    Date = DateTime.Now,
                    Price = Price—hange.Volume / Price—hange.Amount,
                    Amount = Price—hange.Amount,
                    Volume = Price—hange.Volume
                };

                bond.Price—hanges.Add(priceChange);

                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
