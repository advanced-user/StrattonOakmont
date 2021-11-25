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
        private readonly ICompanyRepository _companyRepository;

        public EditModel(AppDBContext appDBContext, ICompanyRepository companyRepository)
        {
            _appDBContext = appDBContext;
            _companyRepository = companyRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }
        public List<StrattonOakmontModels.Security> Securities { get; set; }  

        public void OnGet(int id)
        {
            Company = _appDBContext.Companies.Include(x => x.Security).FirstOrDefault(x => x.Id == id);
            Securities = _appDBContext.Securities.Include(x => x.Stonks).Include(x => x.Abligations).Where(x => x.Company.Id == id).ToList();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (Company != null)
            {
                await _companyRepository.UpdateCompanyAsync(Company, id);
            }

            return RedirectToPage("/AdminArea/Company");
        }
    }
}
