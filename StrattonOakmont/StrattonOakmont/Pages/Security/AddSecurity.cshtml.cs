using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security
{
    public class AddSecurity : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly ICategoryRepository _dbCategory;
        private readonly ISecurityRepository _securityRepository;
        private readonly AppDBContext _dbContext;

        public AddSecurity(ICompanyRepository dbCompany, ICategoryRepository dbCategory,
                            ISecurityRepository securityRepository, AppDBContext dbContext)
        {
            _dbCompany = dbCompany;
            _dbCategory = dbCategory;
            _securityRepository = securityRepository;
            _dbContext = dbContext;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public List<StrattonOakmontModels.Category> Categories { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Security Security { get; set; }

        public void OnGet(int id)
        {
            Company = _dbCompany.FindCompany(id);
            Categories = _dbCategory.GetAllCategories.ToList();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var securityCategory = await _dbContext.Categories.FindAsync(id);

            if (securityCategory != null && Security != null)
            {
                Security.CategorySec = securityCategory;
            }

            Company = await _dbContext.Companies.FindAsync(Company.Id);

            Security.CompanySec = Company;
            await _dbContext.Securities.AddAsync(Security);

            /*
            if (Company.Securities == null)
            {
                Company.Securities = new List<StrattonOakmontModels.Security>();
                Company.Securities.Add(Security);
            }
            else
            {
                Company.Securities.Add(Security);
            }

            _dbContext.Companies.Update(Company);
            */
            await _dbContext.SaveChangesAsync();
            
            return Page();
        }

    }
}