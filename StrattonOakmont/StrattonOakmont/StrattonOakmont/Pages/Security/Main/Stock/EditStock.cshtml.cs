using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class EditStockModel : PageModel
    {
        private readonly IStockRepository _stockRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly AppDBContext _appDBContext;

        public EditStockModel(AppDBContext appDBContext, IStockRepository stockRepository,
                              ICompanyRepository companyRepository, IPriceChangeRepository priceChangeRepository)
        {
            _appDBContext = appDBContext;
            _stockRepository = stockRepository;
            _companyRepository = companyRepository;
            _priceChangeRepository = priceChangeRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.StoÒk Stock { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Securities.Price—hange Price—hange { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Stock = _stockRepository.GetStoÒk(stockId);
            Company = _companyRepository.FindCompany(companyId);
            if (Stock.Price—hanges != null && Stock.Price—hanges.Count != 0)
            {
                Price—hange = _priceChangeRepository.GetLatestStockPriceChage(stockId);
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
            var stock = await _stockRepository.GetStockAsync(Stock.Id);    
            if (Stock != null && stock != null && Price—hange.Amount != 0)
            {
                var priceChange = new StrattonOakmontModels.Securities.Price—hange()
                {
                    Date = DateTime.Now,
                    Price = Price—hange.Volume / Price—hange.Amount,
                    Amount = Price—hange.Amount,
                    Volume = Price—hange.Volume
                };

                stock.Price—hanges.Add(priceChange);
                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
