using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class AddNewPriceModel : PageModel
    {
        private readonly IStockRepository _stockRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly AppDBContext _context;

        public AddNewPriceModel(AppDBContext context, IStockRepository stockRepository,
                                ICompanyRepository companyRepository)
        {
            _stockRepository = stockRepository;
            _context = context;
            _companyRepository = companyRepository; 
        }

        [BindProperty]
        public StrattonOakmontModels.Stoñk Stock { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Stock = _stockRepository.GetStoñk(stockId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPost()
        {
            var stock = await _stockRepository.GetStockAsync(Stock.Id);
            if (Stock != null && stock != null && stock.Amount != 0)
            {
                stock.Amount = Stock.Amount;
                stock.Volume = Stock.Volume;
                stock.Price = Stock.Volume / Stock.Amount;

                var priceChange = new StrattonOakmontModels.Securities.PriceÑhange()
                {
                    Date = DateTime.Now,
                    Price = stock.Price
                };

                stock.PriceÑhanges.Add(priceChange);

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
