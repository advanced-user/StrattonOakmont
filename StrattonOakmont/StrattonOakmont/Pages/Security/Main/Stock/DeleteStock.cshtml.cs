using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class DeleteStockModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly IStockRepository _stockRepository;

        public DeleteStockModel(ICompanyRepository dbCompany, IStockRepository stockRepository)
        {
            _dbCompany = dbCompany;
            _stockRepository = stockRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int StockId { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Company = _dbCompany.FindCompany(companyId);
            StockId = stockId;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _stockRepository.DeleteStockAsync(StockId);

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
