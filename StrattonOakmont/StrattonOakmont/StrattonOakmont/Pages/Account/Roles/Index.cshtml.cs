using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.Account.Roles
{
    public class IndexModel : PageModel
    {
        RoleManager<IdentityRole> _roleManager;

        public IndexModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        
        public List<IdentityRole> Roles { get; set; }

        public void OnGet()
        {
            Roles = _roleManager.Roles.ToList();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await _roleManager.DeleteAsync(role);
            }

            return RedirectToPage("Index");
        }
    }
}
