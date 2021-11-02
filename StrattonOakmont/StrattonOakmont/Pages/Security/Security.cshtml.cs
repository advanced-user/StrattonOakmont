using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class SecurityModel : PageModel
    {
        private readonly ISecurityRepository _db;
        public SecurityModel(ISecurityRepository db)
        {
            _db = db;

            
        }

        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }

        public void OnGet()
        {
            Securities = _db.GetAllSecurities();
        }
    }
}