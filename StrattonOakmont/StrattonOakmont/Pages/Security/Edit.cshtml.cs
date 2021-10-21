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
       



        private readonly ISecurityRepository _securityRepository;

        public EditModel(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }
        public StrattonOakmontModels.Security Security { get; set; }
        public IActionResult OnGet(int id)
        {
            Security = _securityRepository.GetSecurity(id);
            
            if (Security == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(StrattonOakmontModels.Security security)
        {
            Security = _securityRepository.Update(security);
            return RedirectToPage("Security");
        }

    }
}
