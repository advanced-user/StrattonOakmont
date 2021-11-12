using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmont.Pages.Account.Roles
{
    public class UserModel : PageModel
    {
        UserManager<User> _userManager;

        public UserModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }
    }
}
