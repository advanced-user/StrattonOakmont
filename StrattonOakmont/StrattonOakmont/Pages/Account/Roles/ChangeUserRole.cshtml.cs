using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StrattonOakmont.Pages.Account.Roles
{
    public class ChangeUserRoleModel : PageModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public void ChangeRoleViewModel()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }

        //[Authorize(Roles = "admin")]
    //public class HomeController : Controller доступ только админа
    //{
    //    // содержимое контроллера
    //}



        public void OnGet()
        {

        }

    }
}
