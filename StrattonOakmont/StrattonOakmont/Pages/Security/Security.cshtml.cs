using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class SecurityModel : PageModel
    {
        private readonly AppDBContext _appDBContext;
        public SecurityModel(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }

        public void OnGet()
        {
            //Securities = _appDBContext.Securities.Include(x => x.CategorySec).Include(x => x.CompanySec);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            //var security = await _appDBContext.Securities.FindAsync(id);
            //if (security != null)
            //{
            //    _appDBContext.Securities.Remove(security);
            //    await _appDBContext.SaveChangesAsync();
            //}   

            return RedirectToPage("/Security/Security");
        }
    }
}