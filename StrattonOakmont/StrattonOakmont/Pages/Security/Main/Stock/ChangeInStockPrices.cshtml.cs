using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class ChangeInStockPricesModel : PageModel
    {
        private readonly IStockRepository _stockRepository;
        private readonly ICompanyRepository _companyRepository;


        public ChangeInStockPricesModel(IStockRepository stockRepository, ICompanyRepository companyRepository)
        {
            _stockRepository = stockRepository;
            _companyRepository = companyRepository;
        }

        public StrattonOakmontModels.Stoñk Stock { get; set; }

        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Stock = _stockRepository.GetStoñk(stockId);
            Company = _companyRepository.FindCompany(companyId);
        }
    }
}
