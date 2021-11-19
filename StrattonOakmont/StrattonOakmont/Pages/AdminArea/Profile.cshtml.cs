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

        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId)
        {
            UserModel = _userManager.FindByIdAsync(userId).Result;
            if (UserModel != null)
            {
                AllRoles = _roleManager.Roles.ToList();
                UserRoles = await _userManager.GetRolesAsync(UserModel);
                
                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(string userId, List<string> roles)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                user.Email = UserModel.Email;
                user.UserName = UserModel.Email;
                user.Year = UserModel.Year;
                user.Img = UserModel.Img;

                var userRoles = await _userManager.GetRolesAsync(user);

                var addedRoles = roles.Except(userRoles);

                var removedRoles = userRoles.Except(roles);

                await _userManager.AddToRolesAsync(user, addedRoles);

                await _userManager.RemoveFromRolesAsync(user, removedRoles);


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
