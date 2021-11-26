using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stonk
{
    public class DeleteModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly IStonkRepository _stonkRepository;

        public DeleteModel(ICompanyRepository dbCompany, IStonkRepository stonkRepository)
        {
            _dbCompany = dbCompany;
            _stonkRepository = stonkRepository;
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
            await _stonkRepository.DeleteStonkAsync(StockId);

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
