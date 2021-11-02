using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StrattonOakmont.Pages.AdminArea
{
    public class AdminAreaModel : PageModel
    {
        private readonly StrattonOakmontServices.AppDBContext _context;

        public AdminAreaModel(StrattonOakmontServices.AppDBContext context)
		{
            _context = context;
		}

        public IList<StrattonOakmontModels.Security> Security { get; set; }

        public void OnGet()
        {
        }
    }
}
