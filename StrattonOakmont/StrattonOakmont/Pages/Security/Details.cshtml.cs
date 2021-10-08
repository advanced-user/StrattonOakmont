using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class DetailsModel : PageModel
    {
        private readonly ISecurityRepository _securityRepository;
        
        public DetailsModel(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public StrattonOakmontModels.Security Security { get; private set; }

        public void OnGet(int Id)
        {
            Security = _securityRepository.GetSecurity(Id);
        }
    }
}
