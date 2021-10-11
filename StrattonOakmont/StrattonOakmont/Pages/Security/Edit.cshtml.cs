using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class EditModel : PageModel
    {
        private readonly ICompanyRepository _companyRepository;

        public EditModel(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public StrattonOakmontModels.Company Company { get; set; }



        private readonly ISecurityRepository _securityRepository;

        public EditModel(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }
        public StrattonOakmontModels.Security Security { get; set; }
        public IActionResult OnGet(int id)
        {
            Security = _securityRepository.GetSecurity(id);
            Company = _companyRepository.GetCompany(id);
            if (Security == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }



    }
}
