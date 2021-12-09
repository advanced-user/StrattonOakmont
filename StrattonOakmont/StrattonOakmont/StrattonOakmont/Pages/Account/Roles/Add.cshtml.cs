using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StrattonOakmont.Pages.Account.Roles
{
    public class AddModel : PageModel
    {
        RoleManager<IdentityRole> _roleManager;

        public AddModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return Page();
        }
    }
}
