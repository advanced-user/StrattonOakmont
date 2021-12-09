using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Collections.Generic;
using StrattonOakmontModels;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly UserManager<User> _userManager; 
        private readonly ISecurityRepository _dbSecurity;
        private readonly ICompanyRepository _dbCompany;
        private readonly ISecurityRepository _securityRepository;
        public ProfileModel(UserManager<User> userManager, ISecurityRepository dbSecurity, ICompanyRepository dbCompany, ISecurityRepository securityRepository)
        {
            _userManager = userManager;
            _dbSecurity = dbSecurity;
            _dbCompany = dbCompany;
            _securityRepository = securityRepository;
        }
        public List<StrattonOakmontModels.Securities.Main.UserStock> UserStocks { get; set; }
        public IEnumerable<StrattonOakmontModels.Security> Securities { get; set; }
        public IEnumerable<StrattonOakmontModels.Company> Companies { get; set; }
        public List<User> Users { get; set; }

        
        public void OnGet()
        {                   
            Users = _userManager.Users.ToList();           
            UserStocks = _dbSecurity.GetUserStock(User.Identity.Name).ToList();
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