using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Stock
{
    public class AddStockModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        private readonly ICompanyRepository _dbCompany;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISecurityRepository _securityRepository;

        public AddStockModel(ICompanyRepository dbCompany, AppDBContext dbContext,
                             ICategoryRepository categoryRepository,
                             ISecurityRepository securityRepository)
        {
            _dbCompany = dbCompany;
            _dbContext = dbContext;
            _categoryRepository = categoryRepository;
            _securityRepository = securityRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.StoÒk Stock { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

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

            if (securityCategory != null && Stock != null)
            {
                Stock.CategorySec = securityCategory;
            }

            if (Stock != null)
            {
                Stock.Divisibility = Divisibility;
                Stock.Price = Stock.Volume / Stock.Amount;

                Stock.Price—hanges = new List<StrattonOakmontModels.Securities.Price—hange>
                {
                    new StrattonOakmontModels.Securities.Price—hange()
                    {
                        Date = new DateTime(),
                        Price = Stock.Price
                    }
                };
            }

            var company = await _dbCompany.FindCompanyAsync(Company.Id);

            if (company != null)
            {
                if (company.Security != null)
                {
                    var security = await _securityRepository.GetSecurityAsync(company.Security.Id);
                    if (security != null)
                    {
                        if (security.Stocks != null)
                        {
                            security.Stocks.Add(Stock);
                            company.Security = security;
                        }
                        else
                        {
                            security.Stocks = new List<StrattonOakmontModels.StoÒk>();
                            security.Stocks.Add(Stock);
                            company.Security = security;
                        }
                    }
                }
                else
                {
                    var security = new StrattonOakmontModels.Security();
                    security.Stocks = new List<StrattonOakmontModels.StoÒk>();
                    security.Stocks.Add(Stock);
                    company.Security = security;
                }

                await _dbContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = company.Id });
        }
    }
}
