using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Company
{
    public class EditModel : PageModel
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ISecurityRepository _securityRepository;

        public EditModel(ICompanyRepository companyRepository, ISecurityRepository securityRepository)
        {
            _companyRepository = companyRepository;
            _securityRepository = securityRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }
        public IEnumerable<StrattonOakmontModels.Stonk> Stonks { get; set; }
        public IEnumerable<StrattonOakmontModels.Abligation> Abligations { get; set; }

        public void OnGet(int id)
        {
            Company = _companyRepository.FindCompany(id);
            Stonks = _securityRepository.GetAllStonks(Company.Security.Id);
            Abligations = _securityRepository.GetAllAbligation(Company.Security.Id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (Company != null)
            {
                await _companyRepository.UpdateCompanyAsync(Company, id);
            }

            return RedirectToPage("/AdminArea/Company");
        }
    }
}
