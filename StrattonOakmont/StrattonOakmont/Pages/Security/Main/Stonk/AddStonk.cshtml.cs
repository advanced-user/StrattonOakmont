using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stonk
{
    public class AddStonkModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        private readonly ICompanyRepository _dbCompany;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISecurityRepository _securityRepository;

        public AddStonkModel(ICompanyRepository dbCompany, AppDBContext dbContext,
                             ICategoryRepository categoryRepository,
                             ISecurityRepository securityRepository)
        {
            _dbCompany = dbCompany;
            _dbContext = dbContext;
            _categoryRepository = categoryRepository;
            _securityRepository = securityRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Stonk Stonk { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Date Date { get; set; }

        [BindProperty]
        public int CategoryId { get; set; }

        [BindProperty]
        public bool Divisibility { get; set; }

        public void OnGet(int companyId, int categoryId)
        {
            Company = _dbCompany.FindCompany(companyId);
            CategoryId = categoryId;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var securityCategory = await _categoryRepository.FindCategoryAsync(CategoryId);

            if (securityCategory != null && Stonk != null)
            {
                Stonk.CategorySec = securityCategory;
            }

            if (Stonk != null)
            {
                Stonk.Divisibility = Divisibility;

                if (Date != null)
                {
                    Stonk.DateTimesChanges = new List<StrattonOakmontModels.Date> { Date };
                }
            }

            var company = await _dbCompany.FindCompanyAsync(Company.Id);

            if (company != null)
            {
                if (company.Security != null)
                {
                    var security = await _securityRepository.GetSecurityAsync(company.Security.Id);
                    if (security != null)
                    {
                        if (security.Stonks != null)
                        {
                            security.Stonks.Add(Stonk);
                            company.Security = security;
                        }
                        else
                        {
                            security.Stonks = new List<StrattonOakmontModels.Stonk>();
                            security.Stonks.Add(Stonk);
                            company.Security = security;
                        }
                    }
                }
                else
                {
                    var security = new StrattonOakmontModels.Security();
                    security.Stonks = new List<StrattonOakmontModels.Stonk>();
                    security.Stonks.Add(Stonk);
                    company.Security = security;
                }
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = company.Id});
        }
    }
}
