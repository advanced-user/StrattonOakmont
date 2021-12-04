using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Purchase
{

    [Authorize]
    public class PurchaseModel : PageModel
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly UserManager<User> _userManager;
        private readonly AppDBContext _appDBContext;

        public PurchaseModel(ICompanyRepository companyRepository,
                             UserManager<User> userManager, AppDBContext appDBContext,
                             IPriceChangeRepository priceChangeRepository)
        {
            _companyRepository = companyRepository;
            _userManager = userManager;
            _appDBContext = appDBContext;
            _priceChangeRepository = priceChangeRepository;
        }


        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public List<Sto�k> Sto�ks { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public Price�hange Price�hange { get; set; }

        public void OnGet(int companyId)
        {
            Company = _companyRepository.FindCompany(companyId);
            Sto�ks = Company.Security.Stocks.ToList();

            if (Sto�ks.Count != 0)
            {
                Price�hange = _priceChangeRepository.GetLatestStockPriceChage(Sto�ks[0].Id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            Company = _companyRepository.FindCompany(Company.Id);
            Sto�ks = Company.Security.Stocks.ToList();
            Price�hange = _priceChangeRepository.GetPrice�hange(Price�hange.Id);

            if (Sto�ks.Count != 0 && Price�hange.Amount >= Amount)
            {
                var user = await _userManager.Users.Include(x => x.Receipts).ThenInclude(x => x.Stock)
                                                    .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);
                var receipt = new Receipt();

                receipt.Date = DateTime.Now;
                receipt.Company = Company;
                receipt.User = user;
                receipt.Stock = Sto�ks[0];
                receipt.Amount = Amount;
                receipt.Price = Price�hange.Price * Amount;


                await _appDBContext.Receipts.AddAsync(receipt);
                await _appDBContext.SaveChangesAsync();
            }



            return RedirectToPage("/Company/View", new { id = Company.Id });
        }
    }
}
