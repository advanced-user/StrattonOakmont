using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.Security
{
    public class ViewSecuritiesModel : PageModel
    {
        private readonly ISecurityRepository _securityRepository;

        public ViewSecuritiesModel(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }

        public void OnGet()
        {
            Securities = _securityRepository.GetAllSecurities;
        }
    }
}
