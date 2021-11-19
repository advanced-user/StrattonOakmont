using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Company
{
    public class EditModel : PageModel
    {

        private readonly AppDBContext _appDBContext;

        public EditModel(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }
        public List<StrattonOakmontModels.Security> Securities { get; set; }  

        public void OnGet(int id)
        {
            Company = _appDBContext.Companies.Include(x => x.Securities).FirstOrDefault(x => x.Id == id);
            Securities = _appDBContext.Securities.Include(x => x.CategorySec).Where(x => x.CompanySec.Id == id).ToList();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var updateCompany = await _appDBContext.Companies.Include(x => x.Securities).FirstOrDefaultAsync(x => x.Id == id);
            if (Company != null && updateCompany != null)
            {
                updateCompany.Ñapitalization = Company.Ñapitalization;
                updateCompany.Name = Company.Name;
                updateCompany.Desc = Company.Desc;
                updateCompany.IMG = Company.IMG;

                _appDBContext.Companies.Update(updateCompany);
                await _appDBContext.SaveChangesAsync();
            }

            return RedirectToPage("/AdminArea/Company");
        }
    }
}
