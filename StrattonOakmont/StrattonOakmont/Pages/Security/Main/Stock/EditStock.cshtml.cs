using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
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
        public StrattonOakmontModels.Sto�k Stock { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Stock = _stockRepository.GetSto�k(stockId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPost()
        {
            var stock = await _stockRepository.GetStockAsync(Stock.Id);    
            if (Stock != null && stock != null && Stock.Amount != 0)
            {
                stock.Amount = Stock.Amount;
                stock.Volume = Stock.Volume;
                stock.Price = Stock.Volume / Stock.Amount;
               
                var priceChage = await _priceChangeRepository.GetLatestStockPriceChageAsync(stock.Id);
                priceChage.Price = stock.Price;

                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}