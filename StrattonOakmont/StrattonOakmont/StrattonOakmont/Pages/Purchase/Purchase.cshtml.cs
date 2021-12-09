using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securities.Main;
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
        public Stoñk Stoñks { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public PriceÑhange PriceÑhange { get; set; }

        public void OnGet(int companyId)
        {
            Company = _companyRepository.FindCompany(companyId);
            Stoñks = Company.Security.Stocks;

            if (Stoñks != null)
            {
                PriceÑhange = _priceChangeRepository.GetLatestStockPriceChage(Stoñks.Id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            Company = _companyRepository.FindCompany(Company.Id);
            Stoñks = Company.Security.Stocks;
            PriceÑhange = _priceChangeRepository.GetPriceÑhange(PriceÑhange.Id);

            if (Stoñks != null && PriceÑhange.Amount >= Amount)
            {
                var user = await _userManager.Users.Include(x => x.Stocks).Include(x => x.Receipts).ThenInclude(x => x.Stock)
                                                    .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);
                var receipt = new Receipt();

                receipt.Date = DateTime.Now;
                receipt.Company = Company;
                receipt.User = user;
                receipt.Stock = Stoñks;
                receipt.Amount = Amount;
                receipt.Price = PriceÑhange.Price * Amount;
                receipt.Tax = receipt.Price * 0.05;
                PriceÑhange.Amount -= Amount;

                if (user.Stocks == null)
                {
                    user.Stocks = new List<UserStock>() { new UserStock { Stoñk = Stoñks, Amount = Amount } };
                }
                else
                {
                    var userStock = user.Stocks.FirstOrDefault(x => x.Stoñk.Security.Stocks.CompanySec.Id == Company.Id);
                    if (userStock != null)
                    {
                        userStock.Amount += Amount;
                    }
                    else
                    {
                        user.Stocks.Add(new UserStock { Stoñk = Stoñks, Amount = Amount });
                    }
                }

                await _appDBContext.Receipts.AddAsync(receipt);
                await _appDBContext.SaveChangesAsync();
            }



            return RedirectToPage("/Company/View", new { id = Company.Id });
        }
    }
}
