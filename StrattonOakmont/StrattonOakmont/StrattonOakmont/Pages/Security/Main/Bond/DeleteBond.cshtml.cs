using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class DeleteBondModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly IBondRepository _bondRepository;

        public DeleteBondModel(ICompanyRepository dbCompany, IBondRepository bondRepository)
        {
            _dbCompany = dbCompany;
            _bondRepository = bondRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int BondId { get; set; }

        public void OnGet(int companyId, int bondId)
        {
            Company = _dbCompany.FindCompany(companyId);
            BondId = bondId;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bondRepository.DeleteBondAsync(BondId);

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
