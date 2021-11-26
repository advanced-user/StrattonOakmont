using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class EditStockModel : PageModel
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ICategoryRepository _dbCategory;
        private readonly AppDBContext _appDBContext;

        public EditStockModel(ISecurityRepository securityRepository, AppDBContext appDBContext,
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
            //Security = _securityRepository.GetSecurity(id);
            //Categories = _dbCategory.GetAllCategories.ToList();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            //var securityCategory = await _appDBContext.Categories.FindAsync(id);
            //var security = await _appDBContext.Securities.Include(x => x.CategorySec).Include(x => x.CompanySec)
            //    .Include(x => x.UserSec).FirstOrDefaultAsync();

            //if (securityCategory != null)
            //{
            //    if(security.Amount != 0)
            //    {
            //        security.Price = Security.Volume / Security.Amount;
            //    }
            //    else
            //    {
            //        security.Price = 0;
            //    }


            //    security.CategorySec = securityCategory;
            //    security.Volume = Security.Volume;

            //    _appDBContext.Securities.Update(security);
            //    await _appDBContext.SaveChangesAsync();
            //}

            return RedirectToPage("Security");
        }
    }
}
