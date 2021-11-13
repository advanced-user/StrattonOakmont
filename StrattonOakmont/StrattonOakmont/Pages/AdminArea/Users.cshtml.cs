
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using StrattonOakmontModels;


namespace StrattonOakmont.Pages.AdminArea
{
    public class UsersModel : PageModel
    {
        UserManager<User> _userManager;

        public UsersModel(UserManager<User> userManager)
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
