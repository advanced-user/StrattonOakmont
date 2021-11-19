using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using StrattonOakmontModels;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Account.Roles
{
    public class ChangeUserRoleModel : PageModel
    {
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;

        public ChangeUserRoleModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public InputModel Input { get; set; }
        public class InputModel
        {
            public string UserId { get;  set; }
            public string UserEmail { get; set; }
            public List<IdentityRole> AllRoles { get; set; }
            public IList<string> UserRoles { get; set; }
            public InputModel()
            {
                AllRoles = new List<IdentityRole>();
                UserRoles = new List<string>();
            }
        }

        public async Task<IActionResult> OnGetAsync(string userId)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if(user!=null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var allRoles = _roleManager.Roles.ToList();
                Input = new InputModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };
                
                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(string userId, List<string> roles)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                // var allRoles = _roleManager.Roles.ToList();

                var addedRoles = roles.Except(userRoles);

                var removedRoles = userRoles.Except(roles);

                await _userManager.AddToRolesAsync(user, addedRoles);

                await _userManager.RemoveFromRolesAsync(user, removedRoles);

                return RedirectToPage("/AdminArea/Users");
            }

            return NotFound();
        }
    }
}
