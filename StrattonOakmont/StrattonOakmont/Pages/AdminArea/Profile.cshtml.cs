using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels;

namespace StrattonOakmont.Pages.AdminArea
{
    public class ProfileModel : PageModel
    {
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public ProfileModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty]
        public User UserModel { get; set; }

        public void OnGetAsync(string userId)
        {
            UserModel = _userManager.FindByIdAsync(userId).Result;
        }

        public async Task<IActionResult> OnPostAsync(string userId)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                user.Email = UserModel.Email;
                user.UserName = UserModel.UserName;
                user.Year = UserModel.Year;
                user.Img = UserModel.Img;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToPage("/AdminArea/Users");
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
