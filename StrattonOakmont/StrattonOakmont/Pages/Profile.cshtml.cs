using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using System.Linq;
using System.Collections.Generic;
using StrattonOakmontModels;

namespace StrattonOakmont.Pages
{
    public class ProfileModel : PageModel
    {
        UserManager<User> _userManager;

        public ProfileModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToPage("Users");
        }
    }
}