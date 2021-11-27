using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class AddBondModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        private readonly ICompanyRepository _dbCompany;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISecurityRepository _securityRepository;

        public AddBondModel(ICompanyRepository dbCompany, AppDBContext dbContext,
                                  ICategoryRepository categoryRepository,
                                  ISecurityRepository securityRepository)
        {
            _dbCompany = dbCompany;
            _dbContext = dbContext;
            _categoryRepository = categoryRepository;
            _securityRepository = securityRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Bond Bond { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Securities.Price—hange Price—hange { get; set; }

        [BindProperty]
        public int CategoryId { get; set; }

        public void OnGet(int companyId, int categoryId)
        {
            Company = _dbCompany.FindCompany(companyId);
            CategoryId = categoryId;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var securityCategory = await _categoryRepository.FindCategoryAsync(CategoryId);

            if (securityCategory != null && Bond != null)
            {
                Bond.CategorySec = securityCategory;
            }

            if (Bond != null)
            {
                if (Price—hange != null && Price—hange.Amount != 0)
                {
                    Price—hange.Price = Price—hange.Volume / Price—hange.Amount;

                    Bond.Price—hanges = new List<StrattonOakmontModels.Securities.Price—hange>
                    {
                        new StrattonOakmontModels.Securities.Price—hange()
                        {
                            Date = DateTime.Now,
                            Price = Price—hange.Volume / Price—hange.Amount,
                            Amount = Price—hange.Amount,
                            Volume = Price—hange.Volume
                        }
                    };
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
                        if (security.Bonds != null)
                        {
                            security.Bonds.Add(Bond);
                            company.Security = security;
                        }
                        else
                        {
                            security.Bonds = new List<StrattonOakmontModels.Bond>();
                            security.Bonds.Add(Bond);
                            company.Security = security;
                        }
                    }
                }
                else
                {
                    var security = new StrattonOakmontModels.Security();
                    security.Bonds = new List<StrattonOakmontModels.Bond>();
                    security.Bonds.Add(Bond);
                    company.Security = security;
                }

                await _dbContext.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = company.Id });
        }
    }
}
