using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Security
{
    public class EditModel : PageModel
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ICategoryRepository _dbCategory;
        private readonly AppDBContext _appDBContext;

        public EditModel(ISecurityRepository securityRepository, AppDBContext appDBContext,
                            ICategoryRepository dbCategory)
        {
            _securityRepository = securityRepository;
            _appDBContext = appDBContext;
            _dbCategory = dbCategory;
        }
        [BindProperty]
        public StrattonOakmontModels.Security Security { get; set; }

        [BindProperty]
        public List<StrattonOakmontModels.Category> Categories { get; set; }

        public void OnGet(int id)
        {
            Security = _securityRepository.GetSecurity(id);
            Categories = _dbCategory.GetAllCategories.ToList();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var securityCategory = await _appDBContext.Categories.FindAsync(id);
            var security = await _appDBContext.Securities.Include(x => x.CategorySec).Include(x => x.CompanySec)
                .Include(x => x.UserSec).FirstOrDefaultAsync();

            if (securityCategory != null)
            {
                if(security.Amount != 0)
                {
                    security.Price = Security.Volume / Security.Amount;
                }
                else
                {
                    security.Price = 0;
                }
                
               
                security.CategorySec = securityCategory;
                security.Volume = Security.Volume;

                _appDBContext.Securities.Update(security);
                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("Security");
        }
    }
}
